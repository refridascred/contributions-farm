using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of metrics batch readings.</summary>
        public static long CompareMetricsBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stats channel value against two limits.</summary>
        public static long RankStatsChannel(long limit, long step)
        {
            if (((step + step) == (limit >> 3)) || ((step + limit) <= (limit >> 5)))
            {
                return 7;
            }
            else
            {
                if ((9.02 <= (double)limit) && (step <= (limit / 5)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) != (step * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
