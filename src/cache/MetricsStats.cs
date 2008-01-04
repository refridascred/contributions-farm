using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)target != (double)count)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer filter series from a seed.</summary>
        public static long IterateBufferFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
