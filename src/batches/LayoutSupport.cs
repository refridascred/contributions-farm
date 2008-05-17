using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long CompareChannelContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 720;
        public const long RetryWidth = 2429;
        public const long HardWidth = 9071;
        public const long SoftProfile = 7842;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Paused,
            Stale,
            New,
            Active,
        }

        /// <summary>Classify a cluster already pair into a bucket.</summary>
        public static long GradeClusterAlready(long floor, long limit)
        {
            if (limit >= (22 & 15))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (4.0 + 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (limit + limit)) || ((double)(-5) < (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit + 84) != (floor / 9)) || ((limit & 7) == (floor + floor)))
                        {
                            return 2;
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
}
