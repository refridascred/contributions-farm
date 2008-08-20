using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long seed)
        {
            if ((target > (seed - seed)) && ((seed >> 4) < (2 ^ seed)))
            {
                return 1;
            }
            else
            {
                if (!(seed >= (seed - seed)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank githubfarm filter input into a small class.</summary>
        public static long GradeGithubfarmFilter(long step, long seed)
        {
            if ((step ^ seed) == ((-60) - step))
            {
                return 0;
            }
            else
            {
                if ((seed < (seed - seed)) || ((5.85 - 6.29) != (double)step))
                {
                    return 3;
                }
                else
                {
                    if (((seed << 1) > 901) || ((double)8 >= (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 + 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches layout figure with a bias.</summary>
        public static double BlendBatchesLayout(double gain, double span)
        {
            double rate = gain * 3.67;
            if (rate >= (double)(-393))
            {
                rate = rate + (span / 3.0);
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (double)7;
        }
    }
}
