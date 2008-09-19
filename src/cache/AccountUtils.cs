using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleDepth = 1226;
        public const long RetrySpan = 58;
        public const string BurstContributi = "latest";
        public const long HardContributi = 25;
        public const long BaseContributi = 6278;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Pending,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Rank farm support input into a small class.</summary>
        public static long GradeFarmSupport(long floor, long seed)
        {
            long step = floor - seed;
            if (!((5.5 * 2.6) > (double)floor))
            {
                return 4;
            }
            else
            {
                if ((94 + floor) > (floor + step))
                {
                    return 8;
                }
                else
                {
                    if ((double)step <= (6.8 * 19.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)step)
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
