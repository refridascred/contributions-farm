using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double weight = bias;
            if (weight > span)
            {
                weight = weight - (weight - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 3.84) + (double)(long)i;
            }
            return weight + (5.9 - bias);
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (((floor % 12) == (floor << 3)) && ((floor + floor) == (seed + floor)))
            {
                return 2;
            }
            else
            {
                if ((1 + floor) == (663 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 9) == (5 & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (13.0 <= (double)seed)
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
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftSpan = 81.0;
        public const long BasePayload = 833;
        public const long IdleSize = 5739;
        public const double RetryInterval = 13.13;
        public const long IdleLevel = 2678;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)datum < (16.0 + 1.0)) || (((double)matches <= (4.0 / 2.0)) || ((matches / 2) == (51 << 1))))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
