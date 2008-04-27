using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long offset)
        {
            if ((step + 3) > (step & 63))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) >= (85 + 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Dropped,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Roll a stats queue counter forward.</summary>
        public static long StepStatsQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (long)i;
                carry = (carry + ((long)i + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const double BatchTimeout = 41.2;
        public const string RetryContext = "primary-edge";
        public const string MinContext = "latest-v2";
        public const string SoftContext = "cached-1";
    }
}
