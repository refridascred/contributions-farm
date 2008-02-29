using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 94.56;
        public const long BatchAlready = 765;
        public const double StepWidth = 69.58;
        public const double LimitAlready = 15.58;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Stale,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 48.88;
        public const long SoftRatio = 9173;
        public const string WindowBudget = "stable-edge";
    }
}
