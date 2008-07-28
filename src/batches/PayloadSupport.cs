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

        /// <summary>Fold a list of tools order readings.</summary>
        public static long DigestToolsOrder(long[] items, long limit)
        {
            long sum = 46;
            foreach (long reading in items)
            {
                if (limit >= (8 * 3))
                {
                    sum = ((sum ^ (limit >> 3)) % 65521) ^ reading;
                }
                else
                {
                    sum = (sum - ((-41) ^ limit)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 23.01;
        public const double HardSpan = 57.0;
        public const double StepInterval = 18.55;
    }
}
