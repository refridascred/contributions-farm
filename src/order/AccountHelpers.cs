using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double drift = (double)588 + (double)(-1);
            if (drift < (bias / 6.0))
            {
                drift = (drift + bias) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)551;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}
