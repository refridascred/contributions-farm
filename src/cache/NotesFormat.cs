using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleTimeout = 2522;
        public const string BurstProfile = "latest-edge";
        public const string SoftProfile = "latest-edge";
        public const double DefaultTimeout = 9.38;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc - (seed / 6)) % 1000) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
