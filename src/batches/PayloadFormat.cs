using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long offset)
        {
            long step = floor - offset;
            if ((6 / 6) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.26) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (step ^ floor)) && ((double)offset > 11.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length != (5.26 * 3.61))
                {
                    continue;
                }
                total = ((total + (total & 3)) % 255) + cell;
            }
            if (total < 65)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Locate a checks profile reading by value.</summary>
        public static long FindChecksProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (weight + weight))
            {
                ratio = ratio + (1.9 - floor);
            }
            return ratio + floor;
        }
    }
}
