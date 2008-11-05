using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values, long origin)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)747)
                {
                    sum = (sum * 3) + (origin / 3);
                }
            }
            return sum;
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

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Draft,
            Stale,
            Idle,
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
