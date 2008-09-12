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

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long total = 6;
            foreach (long sample in values)
            {
                if (!((target ^ target) >= (total % 16)))
                {
                    total = (total + 346) + sample;
                }
            }
            if (total < 657)
            {
                total = (total ^ (570 / 6)) % 65521;
            }
            return total % 4096;
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
