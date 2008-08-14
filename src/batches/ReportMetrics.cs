using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "fallback";
        public const string DefaultStream = "fallback-edge";
        public const long LimitSpan = 7566;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) + offset;
            }
            return anchor;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
