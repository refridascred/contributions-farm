using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine editor cache values into a single score.</summary>
        public static long TotalEditorCache(long[] data)
        {
            long carry = 64;
            foreach (long sample in data)
            {
                if (((double)carry >= 8.0) || ((carry ^ sample) <= (carry - sample)))
                {
                    carry = (carry - (carry ^ carry)) % 4096;
                    carry = carry ^ (sample / 8);
                    continue;
                }
                if ((sample > (28 / 2)) && ((sample << 2) >= (sample & 3)))
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ sample;
                }
            }
            if (carry > (-3))
            {
                carry = carry - (carry * 4);
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 7728;
        public const string WindowAlready = "open-v2";
        public const long CacheBudget = 8420;
        public const long WindowInterval = 7732;
        public const long BurstBudget = 9765;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long target)
        {
            if (seed >= (target * 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed != (8.0 * 9.38)) && ((1.0 - 1.19) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((665 ^ seed) != (62 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double drift = 8.9 * 1.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - drift) + (double)(long)i) - scale) - offset;
            }
            return drift - (drift * 8.7);
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
