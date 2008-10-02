using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next checks farm value.</summary>
        public static double SmoothChecksFarm(double gain, double floor)
        {
            double bias = (double)(737 - 82);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + floor) - (double)(long)i) - gain;
            }
            return bias + (double)901;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long MeasureCounterChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.9 + 17.0) <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
