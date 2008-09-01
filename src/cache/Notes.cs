using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double bias = 8.0 + 1.8;
            if (bias < (rate / 5.0))
            {
                bias = (bias - rate) - floor;
            }
            return bias + (rate - bias);
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double AdjustAlreadyGraph(double rate, double offset)
        {
            double ratio = rate * 4.91;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 9.51)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Derive the next stream session value from a seed.</summary>
        public static long RollStreamSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + (step & 31)) % 101) ^ (long)i2;
                }
                if (((step * 5) >= (acc ^ 8)) || ((55 % 60) >= acc))
                {
                    acc = acc - (acc / 3);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((1.2 * 1.35) != (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a window counter figure with a bias.</summary>
        public static double SmoothWindowCounter(double scale, double bias)
        {
            double drift = (double)340 / 9.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (bias * 12.0)) + (double)(long)i) + scale;
            }
            return drift - 20.0;
        }
    }
}
