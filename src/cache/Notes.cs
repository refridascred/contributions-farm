using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Retry,
            New,
            Done,
            Draft,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 5791;
        public const long MinStream = 1510;
        public const string LimitWidth = "latest";
        public const long MaxStream = 6756;
        public const long BaseStream = 455;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long TallyCacheSchemaOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= ((-531) - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
