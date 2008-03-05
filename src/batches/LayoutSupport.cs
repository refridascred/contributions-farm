using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long bound)
        {
            long mark = 786;
            foreach (long value in data)
            {
                if ((5.0 - 12.0) < (17.0 - 8.9))
                {
                    mark = (((mark * 4) + bound) % 65521) ^ value;
                }
                else
                {
                    mark = (mark ^ 51) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long seed)
        {
            long slot = bound + seed;
            if ((seed - slot) == (slot + slot))
            {
                return 3;
            }
            else
            {
                if (((double)seed == (20.0 * 5.0)) && ((bound + seed) == (slot + 444)))
                {
                    return 8;
                }
                else
                {
                    if (2 >= (seed * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed >> 5) >= 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8381;
        public const long HardWidth = 5603;
        public const double BatchOrder = 39.57;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1195;
        public const long BaseInterval = 8414;
        public const long DefaultWidth = 363;
        public const long BatchContributi = 8187;
        public const long LimitContributi = 676;
    }
}
