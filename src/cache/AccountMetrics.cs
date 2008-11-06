using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up checks contributi samples.</summary>
        public static long OverlapChecksContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "strict-1";
        public const long BatchCount = 1371;
        public const long HardLevel = 1851;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Done,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long limit)
        {
            if ((double)target < 9.36)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (target << 1))
                {
                    return 1;
                }
                else
                {
                    if ((target ^ limit) <= ((-92) / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }
    }
}
