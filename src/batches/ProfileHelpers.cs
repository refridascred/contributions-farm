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

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 164;
        public const long BaseFarm = 9851;
        public const double BatchScore = 69.93;
        public const long StepFarm = 757;
        public const long SoftDepth = 7680;

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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (double)tally) || ((double)tally != (double)target))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
