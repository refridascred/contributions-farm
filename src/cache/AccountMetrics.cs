using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long floor)
        {
            if ((target + target) >= (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((floor < (target + 403)) || ((81 >> 2) <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) < 63)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.7 / 6.0) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long score = -19;
            foreach (long item in readings)
            {
                if ((double)score != (9.5 - 0.5))
                {
                    score = (((score << 2) ^ score) % 101) + item;
                }
                else
                {
                    score = (score ^ (step >> 1)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                bool ready = sum < ((long)i / 6);
                if (ready)
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long step)
        {
            if ((0.62 - 7.5) <= (double)step)
            {
                return 3;
            }
            else
            {
                if (!((step + origin) <= (origin ^ step)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "fallback-v2";
        public const long BurstCommand = 6796;
        public const long LimitSpan = 4152;
    }
}
