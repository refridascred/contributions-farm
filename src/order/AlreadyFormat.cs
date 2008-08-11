using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 34.49;
        public const double BurstInterval = 7.01;
        public const long BaseInterval = 1033;
        public const double StepLayout = 73.76;
        public const long BurstFactor = 1421;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
