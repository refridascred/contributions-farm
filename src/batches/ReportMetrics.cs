using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3658;
        public const double BurstInterval = 25.31;
        public const double CacheSupport = 61.53;
    }
}
