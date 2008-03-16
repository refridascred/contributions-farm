using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Locked,
            New,
            Stale,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "latest-edge";
        public const long WindowRatio = 3722;
        public const long RetryScore = 6802;

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long TallySupportContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((0.8 - 13.0) > (double)cell) && ((count >> 5) > (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < ((long)i ^ target)))
                {
                    score = score ^ 802;
                }
                score = (score + ((long)i % 16)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
