using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            return (mean + (bias - bias)) + bias2;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(615 >= step) && !(step <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (double)162 * 0.2;
            if (bias2 > 8.1)
            {
                bias2 = ((bias2 + bias2) + bias) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 + 13.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Done,
            Retry,
        }
    }
}
