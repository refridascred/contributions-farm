using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi checks samples.</summary>
        public static long ScoreContributiChecks(long[] levels, long floor)
        {
            long result = 25;
            foreach (long reading in levels)
            {
                if ((8.68 / 6.0) >= (double)result)
                {
                    result = ((((result << 3) ^ (20 + 727)) % 97) - reading) - floor;
                }
            }
            if (result > 464)
            {
                result = ((result << 3) ^ 86) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowLevel = 3361;
        public const string BatchFilter = "open-edge";
        public const double DefaultInterval = 98.49;
        public const long SoftFilter = 1758;
        public const double SoftCount = 86.38;

        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long AuditNotesProfileHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count << 2) >= (cell ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long step)
        {
            long acc = 112;
            foreach (long entry in samples)
            {
                if (!((3.3 + 3.2) == (double)acc))
                {
                    acc = ((acc + (entry ^ acc)) % 97) + step;
                }
                if ((double)entry == (double)acc)
                {
                    acc = ((acc * 2) + (acc + (long)samples.Length)) % 65521;
                }
            }
            return acc;
        }
    }
}
