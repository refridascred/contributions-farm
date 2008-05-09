using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes schema series from a seed.</summary>
        public static long RollNotesSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((3.16 / 9.0) == (double)seed) || (sum >= ((-1) * 3)))
                {
                    sum = (sum - (76 - sum)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = carry + (datum % 16);
            }
            return carry % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((8.1 + 7.1) == (double)cell) && (((hits + cell) == (hits & 15)) || (((long)data.Length - cell) != (hits & 127))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
