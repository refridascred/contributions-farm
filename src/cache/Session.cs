using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) < (count & 15))
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

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (acc - 475))
                {
                    acc = ((acc << 3) ^ entry) % 255;
                }
                else
                {
                    acc = acc + (99 % 7);
                }
                if ((acc + acc) >= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((13.0 > (double)entry) && (((seen + seen) < (entry % 5)) && (((-215) + seen) < (entry & 7))))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }
    }
}
