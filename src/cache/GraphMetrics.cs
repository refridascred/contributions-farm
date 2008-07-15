using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "stable-edge";
        public const string CacheInterval = "latest-edge";
        public const long HardAlready = 2759;
        public const double BaseFactor = 96.57;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long gap = floor + floor2;
            if (((gap >> 1) == (485 + floor2)) || ((gap & 15) != (floor2 & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 == (6.9 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + gap) >= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 17.47;
        public const double IdleCommand = 34.36;
        public const long MinWidth = 4202;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
