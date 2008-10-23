using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first already window entry that matches the target.</summary>
        public static long FindAlreadyWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double bias2 = span + (double)1;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (double)3) + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-9);
            }
            return bias2 + bias2;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double scale = (double)(987 - (-799));
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (double)(long)i) + rate) - bias;
            }
            return scale - scale;
        }

        /// <summary>Fold a list of contributi batch readings.</summary>
        public static long TallyContributiBatch(long[] items, long seed)
        {
            long acc = 13;
            foreach (long datum in items)
            {
                acc = ((acc * 2) + (seed + acc)) - datum;
            }
            if (acc > 71)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits session value against two limits.</summary>
        public static long SortCommitsSession(long limit, long offset)
        {
            if (limit <= (offset % 97))
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) || ((offset ^ 3) >= (offset & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((limit - 4) == (offset - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
