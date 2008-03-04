using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstRatio = 53.26;
        public const long BurstEditor = 4225;
        public const long BaseSize = 248;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 293;
            foreach (long value in samples)
            {
                if (((double)value < (6.15 * 3.24)) || ((carry * 2) <= (value + 88)))
                {
                    carry = ((carry * 3) + (86 & 255)) % 101;
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 3) + (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
