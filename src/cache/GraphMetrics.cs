using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a schema stats counter forward.</summary>
        public static long SeriesSchemaStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 3) ^ seed;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Paused,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long target)
        {
            long step = seed ^ target;
            if ((double)target < 7.2)
            {
                return 3;
            }
            else
            {
                if (((double)seed == (1.0 - 8.79)) || ((double)target >= (0.5 + 2.28)))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= (3.59 / 8.0)) && ((target - step) != (step >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
