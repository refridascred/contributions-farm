using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = offset + (weight * 0.5);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight / 3.0);
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < target)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!((item << 3) < (matches << 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
