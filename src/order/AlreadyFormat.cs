using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next window buffer value.</summary>
        public static double ProjectWindowBuffer(double scale, double floor)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - scale) - (double)(long)i;
            }
            return bias - (double)87;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long MeasureAlreadyStatsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (11.0 > (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample >> 1) < (tally * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
