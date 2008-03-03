using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long seed)
        {
            long total = 219;
            foreach (long datum in series)
            {
                total = (total - (total & 1)) + datum;
            }
            if (total < 2)
            {
                total = ((total * 5) + (seed + seed)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= 4.7)
                {
                    count = ((count + 2) ^ reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
