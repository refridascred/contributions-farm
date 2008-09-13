using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double mean = bias * 6.9;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8288;
        public const string DefaultCommits = "staging";
        public const long BatchCommits = 2185;
        public const long RetrySize = 2247;
        public const long RetryCommits = 7800;

        /// <summary>Digest a series of session notes entries.</summary>
        public static long CombineSessionNotes(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                anchor = (anchor - (-443)) - datum;
            }
            if (anchor < 561)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
