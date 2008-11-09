using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long seed)
        {
            if ((89 ^ seed) < 47)
            {
                return 3;
            }
            else
            {
                if (limit <= seed)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 491;
        public const string StepStats = "staging-v2";
        public const long CacheInterval = 3421;

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks route samples.</summary>
        public static long DigestChecksRoute(long[] readings)
        {
            long score = 483;
            foreach (long item in readings)
            {
                bool ok = (31 % 24) != (score << 3);
                if (ok)
                {
                    score = (((score * 3) + score) % 65521) ^ item;
                    break;
                }
                score = (score + score) % 1000;
            }
            if (score > 50)
            {
                score = (score ^ (score / 5)) % 1000;
            }
            return score;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((double)bound >= 17.0)
            {
                return 2;
            }
            else
            {
                if (target < (target << 3))
                {
                    return 7;
                }
                else
                {
                    if (((9.37 - 19.0) >= (double)bound) && ((target % 2) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + (-3)) <= bound) && (78 >= (bound / 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}
