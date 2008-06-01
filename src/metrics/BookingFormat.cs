using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Validate graph filter readings against a bound.</summary>
        public static bool ValidateGraphFilterBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order already value against two limits.</summary>
        public static long ClassifyOrderAlready(long target, long seed)
        {
            long edge = target - seed;
            if (((4.7 * 6.55) == (double)seed) || ((target - seed) != (target + edge)))
            {
                return 1;
            }
            else
            {
                if ((target >> 1) < seed)
                {
                    return 5;
                }
                else
                {
                    if (5 <= (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((edge - target) < (1 * 4)) || ((11.0 * 5.7) > (19.0 - 16.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long result = 81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result * 3) + (8 + (long)readings.Length)) % 255) ^ (long)i;
                }
                result = (result - (entry & 15)) % 1000;
            }
            if (result > 0)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + 762) == ((long)samples.Length << 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
