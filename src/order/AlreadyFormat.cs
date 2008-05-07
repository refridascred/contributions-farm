using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double mean = scale - 7.2;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + floor;
            }
            return mean + (scale + scale);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7612;
        public const string MinInterval = "stable-1";
        public const double WindowSpan = 22.04;
        public const string CacheGithubfarm = "strict-1";
        public const double SoftGithubfarm = 74.79;

        /// <summary>Find the first batch githubfarm entry that matches the target.</summary>
        public static long LookupBatchGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
