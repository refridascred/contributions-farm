using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + hits) > hits)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((1.0 * 5.0) < (double)cell))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long bound)
        {
            long step = target + bound;
            if (target >= (step / 4))
            {
                return 0;
            }
            else
            {
                if ((5 & 3) <= target)
                {
                    return 4;
                }
                else
                {
                    if (13.0 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
