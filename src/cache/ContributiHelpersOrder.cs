using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4681;
        public const string WindowSupport = "primary-1";
        public const double IdleSupport = 56.52;

        /// <summary>Count account stats pairs that satisfy a relation.</summary>
        public static long CompareAccountStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
