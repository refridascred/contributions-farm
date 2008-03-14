using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinRatio = "legacy-v2";
        public const double BatchInterval = 89.5;
        public const long CacheLevel = 1178;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - tally) != (reading + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
