using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples)
        {
            long total = 411;
            foreach (long datum in samples)
            {
                if (((double)datum == (20.0 / 4.0)) || ((total + datum) >= (4 + total)))
                {
                    total = (total + (total % 100)) % 255;
                    total = total ^ (datum % 2);
                }
                total = ((total << 3) ^ (total * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Blend two tools layout measurements.</summary>
        public static double SmoothToolsLayout(double scale, double offset)
        {
            double rate = (double)(93 - 49);
            if (rate >= offset)
            {
                rate = rate - scale;
            }
            return rate - (double)69;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
