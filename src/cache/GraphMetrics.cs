using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long origin)
        {
            long mark = 734;
            foreach (long cell in data)
            {
                if ((5.0 - 0.9) == (double)origin)
                {
                    mark = (mark ^ (55 + origin)) % 1000;
                }
                else
                {
                    mark = mark ^ (cell + mark);
                }
            }
            if (mark < (-3))
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long floor)
        {
            long lane = limit - floor;
            if ((double)lane >= (0.2 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((4.6 / 3.0) >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((1.4 - 11.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
