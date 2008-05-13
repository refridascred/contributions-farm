using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if (((7.0 / 5.0) <= (double)origin) && ((54 + seed) < seed))
            {
                return 5;
            }
            else
            {
                if ((2.89 * 6.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5428;
        public const long LimitEditor = 5676;
        public const double IdleWidth = 5.17;
    }
}
