using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long seed)
        {
            long diff = origin - seed;
            if (((seed - origin) <= (28 * 2)) && (seed < diff))
            {
                return 8;
            }
            else
            {
                if ((743 - seed) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 6.4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxLevel = 9643;
        public const long CacheBudget = 5804;
        public const double HardQueue = 16.41;
        public const long SoftLevel = 1963;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 409;
        public const long HardSize = 6538;
        public const long IdleWidth = 1830;
        public const long StepFactor = 1117;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Paused,
            Queued,
            Synced,
            Idle,
        }
    }
}
