using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + offset) < (offset + 83))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples)
        {
            long mix = 24;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (mix & 3)) % 97) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally > (9.83 + 10.0))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long sum = 79;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ reading) % 65521;
                if (7.1 > (double)sum)
                {
                    sum = (sum - (sum / 6)) % 65521;
                }
                sum = sum - (sum >> 4);
            }
            if (sum < 6)
            {
                sum = (sum << 2) ^ (sum - origin);
            }
            return sum;
        }
    }
}
