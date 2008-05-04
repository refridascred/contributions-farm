using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool GuardNotesAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (limit > (cell << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 5125;
        public const long IdleDepth = 9434;
        public const double BatchFarm = 75.06;
        public const long BatchLevel = 1793;
        public const long HardFarm = 6180;
    }
}
