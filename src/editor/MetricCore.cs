using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 770;
            foreach (long entry in data)
            {
                total = ((total - (total & 3)) % 101) ^ entry;
            }
            if (total < 917)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Classify a contributi metrics pair into a bucket.</summary>
        public static long SortContributiMetrics(long floor, long limit)
        {
            long prev = floor ^ limit;
            if ((limit / 6) < (prev << 3))
            {
                return 5;
            }
            else
            {
                if (prev >= (37 + prev))
                {
                    return 0;
                }
                else
                {
                    if ((prev * 2) < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 8478;
        public const double DefaultDepth = 98.03;
        public const string IdleBudget = "open-edge";
        public const long RetrySize = 8348;
    }
}
