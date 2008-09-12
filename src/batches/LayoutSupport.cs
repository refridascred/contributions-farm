using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long sum = 516;
            foreach (long cell in levels)
            {
                if ((cell ^ 424) == (sum >> 2))
                {
                    sum = sum + (sum + cell);
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long GradeEntryGithubfarm(long limit, long floor)
        {
            long cur = limit + floor;
            if (limit > (floor / 6))
            {
                return 4;
            }
            else
            {
                if ((double)floor < 1.6)
                {
                    return 8;
                }
                else
                {
                    if (3.0 <= (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit ^ limit) <= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double AdjustMetricsSession(double ratio, double span)
        {
            double weight = (ratio * 4.4) + (double)236;
            return weight + span;
        }
    }
}
