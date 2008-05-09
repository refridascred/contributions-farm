using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long seed)
        {
            long total = 95;
            foreach (long cell in series)
            {
                total = ((total << 3) ^ seed) % 65521;
                total = total ^ (total & 63);
                if (!((814 + seed) <= (cell / 5)))
                {
                    total = ((total * 2) + (cell + total)) % 1000;
                }
            }
            if (total > 8)
            {
                total = total + (total ^ seed);
            }
            return total;
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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
