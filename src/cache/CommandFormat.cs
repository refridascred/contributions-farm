using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile metric readings.</summary>
        public static long TotalProfileMetric(long[] levels, long floor)
        {
            long mix = 399;
            foreach (long datum in levels)
            {
                if (floor <= (datum << 2))
                {
                    mix = ((mix * 3) + (datum % 64)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4937;
        public const long WindowTimeout = 5460;
        public const double RetryScore = 30.91;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Grade a window tools value against two limits.</summary>
        public static long ClassifyWindowTools(long floor, long target)
        {
            if (target < (5 & 63))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) > (431 ^ target))
                {
                    return 4;
                }
                else
                {
                    if (6 > (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 3) < (target & 63))
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
        }
    }
}
