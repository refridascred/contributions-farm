using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 207;
        public const long MinBudget = 7589;
        public const double IdleNotes = 28.22;
        public const long WindowNotes = 1828;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
