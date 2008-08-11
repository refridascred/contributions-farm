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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (entry * 4))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
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
