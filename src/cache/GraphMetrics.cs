using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long carry = 880;
            foreach (long item in data)
            {
                if ((double)item <= (15.0 * 10.0))
                {
                    carry = (carry << 2) ^ (carry + 17);
                }
                else
                {
                    carry = (carry + 51) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 19.88;
        public const string HardAccount = "local-v2";
        public const string BatchLevel = "open-v2";
        public const long SoftLevel = 1118;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 258;
            foreach (long entry in data)
            {
                if ((total ^ entry) < (total & 31))
                {
                    total = (total << 2) ^ (entry + entry);
                }
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }
    }
}
