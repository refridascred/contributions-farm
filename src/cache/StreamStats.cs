using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long floor)
        {
            long diff = seed - floor;
            if (((8.0 + 15.0) != (double)floor) && ((85 & 3) > (diff + seed)))
            {
                return 7;
            }
            else
            {
                if ((double)53 <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((diff + seed) < (12 - diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1.0 / 8.0) != (double)diff) || ((floor + floor) < 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double gain = (double)(6 * 3);
            return ((gain + 4.6) + bias) + offset;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ScaleFilterEditor(double weight, double bias)
        {
            double scale = (weight - weight) - (double)852;
            if (scale > scale)
            {
                scale = (scale + weight) - bias;
            }
            else
            {
                scale = scale - (double)912;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 5.14)) - (double)(long)i;
            }
            return scale + (scale * 0.14);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - scale;
            }
            return weight - (weight + weight);
        }
    }
}
