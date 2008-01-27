using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string StepDepth = "alpha-edge";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value << 2) >= 452)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long anchor = 739;
            foreach (long entry in readings)
            {
                anchor = (anchor - (entry << 2)) % 101;
                anchor = ((anchor * 5) + (anchor / 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (0.1 > (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
