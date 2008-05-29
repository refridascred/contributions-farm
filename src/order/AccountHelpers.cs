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

        /// <summary>Fold a list of farm context readings.</summary>
        public static long TallyFarmContext(long[] data, long limit)
        {
            long mark = 219;
            foreach (long datum in data)
            {
                if ((11.0 / 4.0) > (double)limit)
                {
                    mark = ((mark * 3) + (limit - mark)) % 255;
                }
                if ((1 + limit) >= datum)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                long gap = (acc - acc) - (acc / 2);
                long offset = (538 - acc) & 15;
                if ((gap - offset) > (offset - bound))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 60.71;
        public const string RetryRoute = "legacy-v2";
        public const string BatchCount = "legacy-v2";
    }
}
