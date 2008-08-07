using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 755;
        public const long BatchTools = 9502;
        public const double StepTools = 2.48;
        public const long WindowTools = 1426;
        public const long RetrySize = 5208;

        /// <summary>Count token route pairs that satisfy a relation.</summary>
        public static long PairTokenRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
