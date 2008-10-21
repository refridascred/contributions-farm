using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((bound / 9) > (34 & 1))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSize = "open-edge";
        public const double HardWindow = 46.28;
        public const double StepScore = 54.35;
        public const long MaxInterval = 412;
        public const double BatchRatio = 4.41;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
