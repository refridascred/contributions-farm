using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of batch stream readings.</summary>
        public static long MatchBatchStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((56 - 12) != (entry / 7))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long GradeBatchCache(long limit, long limit2)
        {
            if (limit2 >= (limit2 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit ^ limit2) < limit) && (2.58 >= (double)limit2))
                {
                    return 2;
                }
                else
                {
                    if ((limit + 2) == (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Idle,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "latest-edge";
        public const double BurstDepth = 11.34;
        public const long BaseDepth = 9279;
    }
}
