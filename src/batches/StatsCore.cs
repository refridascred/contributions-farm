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

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
