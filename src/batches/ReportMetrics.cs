using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (offset + ratio))
            {
                ratio = ratio - (scale * 1.14);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (18.0 * 2.1)) - (double)(long)i;
            }
            return ratio - (ratio / 5.0);
        }
    }
}
