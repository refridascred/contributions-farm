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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (14 > (seed % 3))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
