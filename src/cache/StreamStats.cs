using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Closed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double weight = bias - (double)687;
            if (weight < (double)691)
            {
                weight = weight + 7.8;
            }
            return weight + floor;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) > (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
