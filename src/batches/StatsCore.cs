using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9126;
        public const long HardAccount = 8681;
        public const long MinAccount = 8991;
        public const double BatchAccount = 38.7;
        public const double SoftInterval = 63.64;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long RollCacheContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((6.2 - 19.0) > (double)step))
                {
                    total = ((total * 4) + total) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
