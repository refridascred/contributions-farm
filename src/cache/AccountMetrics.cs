using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry filter input into a small class.</summary>
        public static long RankEntryFilter(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 * 2) == ((-17) + seed))
            {
                return 7;
            }
            else
            {
                if ((offset + seed) <= (seed2 * 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long carry = 1;
            foreach (long item in levels)
            {
                if (!((carry / 7) > (item - item)))
                {
                    carry = ((carry << 2) ^ (742 - (-1))) % 97;
                }
                carry = (carry ^ (572 + carry)) % 97;
                carry = (carry ^ (item * 3)) % 101;
            }
            return carry % 97;
        }
    }
}
