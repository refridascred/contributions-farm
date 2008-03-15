using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 8975;
        public const long StepStream = 3098;
        public const double DefaultStream = 56.17;
        public const double BurstStream = 78.28;
        public const long MinStream = 7422;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound + 766) <= (target * 2))
            {
                return 3;
            }
            else
            {
                if ((347 > (floor + floor)) || ((floor - bound) >= (target + bound)))
                {
                    return 0;
                }
                else
                {
                    if (bound > target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                score = score - (cell + cell);
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step / 8) <= step)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinRatio = 74.89;
        public const long DefaultProfile = 6158;
        public const string BaseTimeout = "local";
        public const double MaxProfile = 12.64;
        public const long StepProfile = 8537;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long floor)
        {
            long lane = target + floor;
            if ((lane & 3) == (target / 6))
            {
                return 3;
            }
            else
            {
                if (!((56 * 3) >= lane))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (6.72 - 0.4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
