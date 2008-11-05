using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "primary";
        public const long IdleStream = 5952;
        public const long WindowStream = 7802;
        public const double WindowSpan = 5.3;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 7101;
        public const long SoftNotes = 414;
        public const double HardLevel = 95.63;
        public const double DefaultSize = 69.64;
    }
}
