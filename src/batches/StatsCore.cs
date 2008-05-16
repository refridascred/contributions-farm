using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Classify a metrics entry pair into a bucket.</summary>
        public static long RankMetricsEntry(long offset, long target)
        {
            if (offset >= (target % 97))
            {
                return 4;
            }
            else
            {
                if ((target + 4) > (-45))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            New,
            Pending,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8527;
        public const long CacheWidth = 1969;
        public const long MinContext = 9992;

        /// <summary>Look up the position of a notes tools sample.</summary>
        public static long LocateNotesToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
