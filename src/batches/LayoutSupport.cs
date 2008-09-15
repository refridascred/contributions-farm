using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the order editor entries that pass the check.</summary>
        public static long MeasureOrderEditorOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item >= (18.0 * 11.0))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long floor)
        {
            long edge = step + floor;
            if ((double)step > (double)edge)
            {
                return 5;
            }
            else
            {
                if (!((edge << 1) < (floor - step)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRatio = 82.26;
        public const long CacheRoute = 9724;
        public const long MinLevel = 9180;
        public const string IdleRoute = "strict-1";
        public const double HardCount = 98.84;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry * 5) + (step << 3)) ^ (long)i2;
                }
                carry = ((carry << 3) ^ carry) % 255;
                carry = (carry * 5) + ((long)i ^ step);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
