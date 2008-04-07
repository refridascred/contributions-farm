using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheBudget = 8110;
        public const long MaxStats = 6383;
        public const long IdleInterval = 312;
        public const long HardStats = 1413;

        /// <summary>Validate contributi record readings against a bound.</summary>
        public static bool GuardContributiRecordRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long bound)
        {
            if (target < ((-88) >> 2))
            {
                return 1;
            }
            else
            {
                if (((bound / 9) > (bound + 5)) && (392 > target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Failed,
            Pending,
            Ready,
        }
    }
}
