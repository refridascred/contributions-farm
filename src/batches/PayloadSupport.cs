using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc + 2)) % 255;
                if ((acc * 2) <= (entry & 3))
                {
                    acc = (acc ^ (acc - entry)) % 4096;
                }
            }
            if (acc < 282)
            {
                acc = (acc - (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 23.01;
        public const double HardSpan = 57.0;
        public const double StepInterval = 18.55;
    }
}
