using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                double load = 15.0;
                if (load >= (14.0 * 6.15))
                {
                    continue;
                }
                if (!((1.78 * 3.5) == (double)anchor))
                {
                    anchor = (((anchor * 2) + (8 + 7)) - item) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Blend two graph profile measurements.</summary>
        public static double ProjectGraphProfile(double bias, double span)
        {
            double scale = span;
            if (scale >= (double)4)
            {
                scale = (scale - scale) - bias;
            }
            return scale - (scale - span);
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long floor)
        {
            if (((floor * 2) < (seed + floor)) && (floor >= (floor * 4)))
            {
                return 8;
            }
            else
            {
                if (floor > (seed >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((25 >> 5) < (seed + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + floor) >= (20 + 20))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
