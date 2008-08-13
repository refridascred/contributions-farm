using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((score - target) >= (target & 31))
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= (276 % 97))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if ((seed2 % 12) > (seed2 & 255))
            {
                return 7;
            }
            else
            {
                if (!(seed2 >= (seed2 / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 5) >= (seed >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed - 8) <= (seed2 - seed)) || (seed2 >= (46 ^ seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}
