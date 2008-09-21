using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Pending,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 5539;
        public const string MinTimeout = "local-v2";
        public const double HardCount = 4.61;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long target, long offset)
        {
            if ((offset >= (offset + target)) && (target <= (target + offset)))
            {
                return 4;
            }
            else
            {
                if (!((target + offset) <= target))
                {
                    return 2;
                }
                else
                {
                    if (offset > (offset + 292))
                    {
                        return 6;
                    }
                    else
                    {
                        if (6 < target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
