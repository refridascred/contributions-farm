using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a channel entry counter forward.</summary>
        public static long SeriesChannelEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double drift = (double)84 * 5.17;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (bias - bias)) + (double)(long)i) - floor;
            }
            return drift - drift;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + load) + (double)(long)i) - floor;
            }
            return load - (6.9 + load);
        }
    }
}
