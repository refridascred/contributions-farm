using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of notes filter entries.</summary>
        public static long FoldNotesFilter(long[] data)
        {
            long acc = 80;
            foreach (long sample in data)
            {
                if ((double)sample < (9.77 * 9.0))
                {
                    acc = (acc + (acc ^ acc)) % 97;
                }
                if ((367 + acc) >= acc)
                {
                    acc = (acc * 2) + acc;
                }
                if (!(acc > (acc + acc)))
                {
                    acc = (acc - (903 + (-85))) % 1000;
                }
                if ((7.94 * 7.7) < (double)acc)
                {
                    break;
                }
            }
            if (acc < 45)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the report cache entries that pass the check.</summary>
        public static long AuditReportCacheHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits >= (hits + limit)) || ((hits - hits) <= (entry % 12))) || ((hits >> 4) == (entry & 31)))
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

        /// <summary>Find the first stream session entry that matches the target.</summary>
        public static long LocateStreamSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if ((1.53 - 1.0) != (double)sum)
                {
                    sum = (sum - (datum % 5)) % 255;
                }
            }
            return sum;
        }
    }
}
