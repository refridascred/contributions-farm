using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 34;
            foreach (long reading in readings)
            {
                if ((double)state <= (4.3 + 3.1))
                {
                    state = (state * 3) + reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double drift = (double)(23 * 5);
            return (drift - (span + 15.0)) + gain;
        }

        /// <summary>Derive the next githubfarm cache value from a seed.</summary>
        public static long RollGithubfarmCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - offset) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
