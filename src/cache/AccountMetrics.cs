using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long AuditFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor2 ^ offset) >= (floor2 / 6))
            {
                return 2;
            }
            else
            {
                if ((floor2 >> 4) >= (offset * 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
