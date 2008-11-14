using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long mix = 82;
            foreach (long entry in levels)
            {
                if ((2.2 + 5.84) == (double)mix)
                {
                    mix = (mix + mix) % 65521;
                }
                if ((506 <= mix) && ((double)entry != (8.8 / 3.0)))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix << 3) ^ (mix >> 2);
            }
            return mix % 4096;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = -414;
            foreach (long datum in series)
            {
                if ((2.7 - 4.2) < (double)datum)
                {
                    state = state ^ (datum - state);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 8)
            {
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 17.05;
        public const long BurstRatio = 5139;
        public const long BaseRoute = 454;
        public const long BatchRatio = 4349;
        public const string MinRoute = "stable-v2";

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = (double)10 - (2.0 + ratio);
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) + floor;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = 2;
            foreach (long value in levels)
            {
                mix = (mix - mix) % 97;
                mix = (mix * 2) + (mix - value);
            }
            if (mix > 71)
            {
                mix = (mix + ((long)levels.Length + mix)) % 4096;
            }
            return mix % 65521;
        }
    }
}
