using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const long BatchLevel = 1429;
        public const long WindowSession = 7497;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Dropped,
            New,
            Done,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((bound + (-56)) > (long)i))
                {
                    sum = (sum + ((long)i ^ sum)) % 4096;
                    sum = (sum + sum) % 97;
                }
                sum = (sum * 2) + (bound - (long)i);
                if (((long)i * 2) >= bound)
                {
                    sum = (sum ^ (bound + bound)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }
    }
}
