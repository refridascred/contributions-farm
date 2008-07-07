using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((seed % 3) <= (value + (-258)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8718;
        public const string BurstBudget = "local";
        public const long BaseWidth = 1967;
        public const long MaxTimeout = 3;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long sum = 644;
            foreach (long value in items)
            {
                if (((9.0 + 0.99) <= (double)value) || ((2 << 3) <= value))
                {
                    sum = ((sum * 5) + origin) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate farm queue samples.</summary>
        public static long DigestFarmQueue(long[] data, long seed)
        {
            long total = 4;
            foreach (long entry in data)
            {
                if ((total % 16) > total)
                {
                    total = (total ^ (total + total)) ^ entry;
                }
                if ((seed / 8) == (271 + seed))
                {
                    total = total - (total ^ seed);
                }
                else
                {
                    total = (total + (341 * 3)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
