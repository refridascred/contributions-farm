using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 80.32;
        public const double BatchCache = 95.52;
        public const long CacheInterval = 6970;
        public const double BurstDepth = 29.22;
        public const long RetryCache = 9119;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long CountEntryCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) < cell)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values, long floor)
        {
            long carry = -9;
            foreach (long reading in values)
            {
                if ((7.32 - 7.36) > (double)carry)
                {
                    carry = (carry + (floor + reading)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
