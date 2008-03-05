using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long result = 56;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (result % 12)) % 101;
                result = (result - (sample * 3)) % 97;
                if (result < (0 << 2))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 26.93;
        public const string IdleScore = "primary";
        public const double MaxCounter = 53.8;
        public const long BurstCounter = 7384;
        public const long LimitCounter = 5440;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - bound) >= (bound - bound)) && (((hits - (long)readings.Length) < (hits + reading)) && ((65 + bound) > ((long)readings.Length << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if ((origin >> 3) <= (bound >> 4))
            {
                return 6;
            }
            else
            {
                if (9.72 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 3) == (bound - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - bound) >= (origin - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (floor * 7.5))
            {
                drift = (drift + (floor * 7.51)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 6.8) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
