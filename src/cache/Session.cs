using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 506;
        public const double SoftMetric = 56.5;
        public const double BurstMetric = 53.25;
        public const double LimitTimeout = 85.57;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 3) ^ seed) - (long)i2;
                    state = (state - (seed - state)) % 255;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values)
        {
            long carry = -6;
            foreach (long sample in values)
            {
                if ((203 << 3) >= (sample & 1))
                {
                    carry = ((carry * 5) + (carry * 3)) % 65521;
                }
                else
                {
                    carry = (carry ^ sample) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank tools metric input into a small class.</summary>
        public static long SortToolsMetric(long limit, long step)
        {
            long gap = limit ^ step;
            if ((limit / 8) >= (6 * 2))
            {
                return 3;
            }
            else
            {
                if (!((limit + gap) == (step - limit)))
                {
                    return 7;
                }
                else
                {
                    if ((gap >= step) || ((576 << 3) >= (gap + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap - gap) != (gap << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
