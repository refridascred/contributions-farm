using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values)
        {
            long result = 61;
            foreach (long cell in values)
            {
                result = (result + cell) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long seed)
        {
            if ((0 / 9) >= bound)
            {
                return 5;
            }
            else
            {
                if ((9.9 / 3.0) >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) < (bound / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed ^ seed) == (bound & 63))
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

        /// <summary>Count the order window entries that pass the check.</summary>
        public static long CountOrderWindowOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (6.9 * 4.6))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
