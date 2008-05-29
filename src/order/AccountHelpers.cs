using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                long prev = (mark + seed) & 31;
                mark = (mark ^ (seed ^ prev)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ limit) >= 8)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order batch entries.</summary>
        public static long TotalOrderBatch(long[] data)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((reading % 12) >= (reading + total))
                {
                    total = (total - reading) % 65521;
                    total = (total + (total + total)) % 65521;
                }
                if (((reading - reading) <= (29 & 255)) && (total >= (total % 16)))
                {
                    total = ((total << 3) ^ (reading + reading)) % 65521;
                }
                else
                {
                    total = (total + (total - reading)) % 255;
                }
            }
            if (total < 4)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 97;
        }

        /// <summary>Count the entry editor entries that pass the check.</summary>
        public static long TallyEntryEditorOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((30 + 59) == (0 + entry))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
