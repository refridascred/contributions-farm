using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double gain = (double)(56 + 0);
            if (gain < (bias2 + bias2))
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - bias;
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
