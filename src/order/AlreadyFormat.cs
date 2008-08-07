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

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ (result ^ offset);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
