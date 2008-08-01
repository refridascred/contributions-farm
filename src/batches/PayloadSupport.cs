using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long WeighBufferRoute(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (((score << 2) <= (30 - (-6))) || (score < (entry << 3)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                else
                {
                    score = score - (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 43.82;
        public const double BaseNotes = 71.76;
        public const long StepFactor = 4403;
        public const double WindowDepth = 96.19;
        public const long HardNotes = 9785;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (82 >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
