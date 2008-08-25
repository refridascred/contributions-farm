using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer support input into a small class.</summary>
        public static long SortBufferSupport(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((-482) <= span)
            {
                return 3;
            }
            else
            {
                if ((span << 1) <= (origin - origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed != (0.4 - 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.79 + 3.96) < (double)span)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((bound + hits) != ((long)values.Length / 8)) || ((cell + (-8)) != (hits + 524))) || ((hits * 2) >= (bound + 21)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + floor;
            }
            return mean + (double)501;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitSpan = 42.81;
        public const long SoftTimeout = 6958;
        public const double RetryLevel = 34.81;
        public const double RetryFactor = 35.68;
    }
}
