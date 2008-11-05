using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 31) >= count)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long CountPayloadFilterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count << 1) == (sample % 100))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 96.37;
        public const string BurstLevel = "cached-v2";
        public const long BaseCommits = 8326;
        public const long StepCommits = 6523;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long seed)
        {
            long next = target + seed;
            if (((next - seed) > (seed >> 3)) || ((double)seed == (1.4 * 4.2)))
            {
                return 2;
            }
            else
            {
                if (!((target + target) >= (target / 5)))
                {
                    return 1;
                }
                else
                {
                    if (target < (target - next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 25;
            foreach (long cell in series)
            {
                if ((acc << 2) != (393 + acc))
                {
                    break;
                }
                else
                {
                    acc = (acc - (acc / 9)) % 255;
                }
                if ((54 - cell) <= (acc & 1))
                {
                    acc = ((acc * 2) + (4 + acc)) % 97;
                }
                if ((double)acc > 2.2)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
