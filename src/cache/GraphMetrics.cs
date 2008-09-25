using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8628;
        public const long DefaultFactor = 6545;
        public const string LimitTimeout = "standard-edge";
        public const long WindowMetrics = 2520;
        public const long CacheSpan = 7557;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 135;
            foreach (long entry in levels)
            {
                result = (result + (entry >> 2)) % 4096;
                result = (result * 3) + (entry + entry);
            }
            return result % 65521;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Pending,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
