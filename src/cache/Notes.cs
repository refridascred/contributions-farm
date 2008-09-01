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

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long floor)
        {
            if ((double)offset == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((offset % 8) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (6.31 < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
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
