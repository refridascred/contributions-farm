using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long DigestTokenEditor(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((double)value > (13.0 - 8.32))
                {
                    long slot = (value & 1) & 1;
                    anchor = (anchor + (slot % 60)) % 255;
                }
                if (value >= (652 % 2))
                {
                    anchor = ((anchor * 4) + value) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Blend two stats metrics measurements.</summary>
        public static double BlendStatsMetrics(double weight, double bias)
        {
            double gain = weight;
            return gain - (bias * 8.2);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
