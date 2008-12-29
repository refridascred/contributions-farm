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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((2 + mark) != (mark ^ origin))
                {
                    mark = (mark * 4) + mark;
                }
                else
                {
                    mark = (mark - origin) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) < reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
