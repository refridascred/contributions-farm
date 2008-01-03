using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 28;
        public const long WindowFactor = 7918;
        public const double SoftRatio = 0.33;
        public const string BatchStream = "alpha-1";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(529 >= (reading - reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
