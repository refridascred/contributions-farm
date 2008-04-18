using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long total = -660;
            foreach (long entry in samples)
            {
                total = (((total << 3) ^ (entry >> 5)) % 1000) - origin;
            }
            return total % 1000;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = 3.4;
            if (drift >= drift)
            {
                drift = (drift - (drift * 3.02)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + 12.0;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowWidth = 4261;
        public const string CacheFactor = "stable-edge";
        public const long BurstReport = 1154;
        public const long MaxReport = 1950;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (anchor - 93)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
