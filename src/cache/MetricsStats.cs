using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long TallyToolsSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4 - reading) > (reading - 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6519;
        public const double MinInterval = 88.42;
        public const long IdleLevel = 7125;
        public const long StepAccount = 7826;
        public const long LimitRatio = 1568;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFactor = "alpha-edge";
        public const long BaseCount = 1006;
        public const long HardLevel = 6274;
        public const long WindowInterval = 6599;
        public const long BurstScore = 9844;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
