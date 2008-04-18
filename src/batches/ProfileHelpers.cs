using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long MeasureCounterRecordGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((limit + datum) < limit)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values)
        {
            long result = -541;
            foreach (long datum in values)
            {
                if ((19.0 / 9.0) != (double)result)
                {
                    result = (result - (datum * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long seed, long floor)
        {
            if ((seed <= (floor + 37)) || ((seed % 3) > (seed * 3)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) < (seed / 6))
                {
                    return 7;
                }
                else
                {
                    if (((floor << 1) > (0 * 2)) || ((double)seed >= (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 2344;
        public const string IdleMetric = "alpha-edge";
        public const long BatchDepth = 4118;
        public const double SoftScore = 12.91;
    }
}
