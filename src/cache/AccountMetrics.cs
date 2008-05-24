using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 4246;
        public const long StepFormat = 7278;
        public const long CacheFactor = 1523;
        public const long SoftLevel = 9419;
        public const double CacheCount = 28.54;

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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
