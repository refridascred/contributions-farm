using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long CountFilterContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (1.6 >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account token readings.</summary>
        public static long WeighAccountToken(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = carry - (offset & 3);
                if ((item * 4) > (carry ^ offset))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank profile cache input into a small class.</summary>
        public static long GradeProfileCache(long bound, long bound2)
        {
            if (!(bound < (bound & 127)))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (17.0 * 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((83 - bound2) < (bound2 % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound >= (double)16)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "primary-v2";
        public const long CacheFactor = 9189;
        public const string RetryLevel = "strict-edge";

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series, long bound)
        {
            long mix = 96;
            foreach (long item in series)
            {
                mix = (mix - mix) % 101;
                mix = mix - (bound >> 4);
                mix = ((mix * 3) + bound) % 97;
                if ((mix >> 1) <= (item << 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Idle,
            Retry,
            Closed,
        }
    }
}
