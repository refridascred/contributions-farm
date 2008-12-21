using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) != (long)levels.Length)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long RollCommandFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long score = 440;
            foreach (long datum in series)
            {
                if (((double)datum < (double)bound) || ((bound + bound) <= datum))
                {
                    score = score ^ (bound + 0);
                }
                else
                {
                    score = score ^ (bound + datum);
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (double)1)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (4.8 + 1.3)) + (double)(long)i;
            }
            return bias2 - 19.0;
        }
    }
}
