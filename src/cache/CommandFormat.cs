using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
