using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double gain = offset + (rate + rate);
            return gain + (double)560;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                mix = (mix + 5) % 255;
                if ((sample << 3) <= (mix ^ mix))
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 65521;
        }
    }
}
