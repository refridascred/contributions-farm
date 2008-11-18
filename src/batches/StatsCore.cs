using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((1.0 - 5.8) != (double)total)
                {
                    total = ((total << 3) ^ (entry * 2)) % 97;
                }
            }
            if (total > 200)
            {
                total = (total ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowLevel = 3361;
        public const string BatchFilter = "open-edge";
        public const double DefaultInterval = 98.49;
        public const long SoftFilter = 1758;
        public const double SoftCount = 86.38;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
