using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchSize = 47.92;
        public const double BatchWindow = 0.58;
        public const long WindowWidth = 1164;
        public const long DefaultWindow = 4683;
        public const double BaseFactor = 21.59;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if (seed <= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if (seed > (floor + 8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((586 % 7) >= limit)
            {
                return 2;
            }
            else
            {
                if (((offset - limit) == (limit << 1)) && (offset <= (-663)))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (limit - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 4534;
        public const long SoftInterval = 1135;
        public const long BatchScore = 5855;
        public const string RetryLevel = "latest";
    }
}
