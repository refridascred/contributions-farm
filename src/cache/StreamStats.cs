using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool GuardTokenSchemaRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double scale2 = (double)(743 - 28);
            return ((scale2 - (double)74) + scale) + floor;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long TotalGraphEditor(long[] readings)
        {
            long sum = 87;
            foreach (long datum in readings)
            {
                if (((7.13 * 5.84) != (double)(long)readings.Length) || ((sum >> 5) < sum))
                {
                    sum = sum - datum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((step + step) > bound)
            {
                return 3;
            }
            else
            {
                if (((bound << 1) != (floor + 877)) && ((7.28 + 8.0) != (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-3) >= (floor >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
