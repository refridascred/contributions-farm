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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long score = 59;
            foreach (long cell in items)
            {
                score = (score - cell) % 65521;
                score = ((score * 4) + cell) % 97;
            }
            if (score < 5)
            {
                score = ((score << 2) ^ origin) % 65521;
            }
            return score % 65521;
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
