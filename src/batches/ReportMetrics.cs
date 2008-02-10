using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate order record samples.</summary>
        public static long ScoreOrderRecord(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = (mix + (mix + mix)) % 101;
                if (((13.0 * 5.4) < (double)sample) && ((mix ^ sample) < sample))
                {
                    mix = (mix + (sample & 31)) % 101;
                }
                else
                {
                    mix = mix ^ mix;
                }
                if ((mix + mix) == (5 >> 4))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
