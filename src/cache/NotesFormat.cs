using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double drift = (double)(3 ^ 745);
            if (drift > (bias / 8.0))
            {
                drift = drift + (bias + rate);
            }
            else
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (10.0 - drift)) + (double)(long)i;
            }
            return drift - (bias + 5.8);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long mix = 14;
            foreach (long reading in series)
            {
                mix = (mix - reading) % 4096;
            }
            if (mix > 28)
            {
                mix = (mix + (bound % 24)) % 255;
            }
            return mix;
        }
    }
}
