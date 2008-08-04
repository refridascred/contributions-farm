using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long limit)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (((carry >> 5) < limit) || ((9.0 + 1.0) <= (double)limit))
                {
                    carry = ((carry * 5) + (carry - item)) % 255;
                }
                else
                {
                    carry = carry - (item + 957);
                }
            }
            if (carry > 16)
            {
                carry = (carry + (limit >> 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 8982;
        public const long MaxRoute = 9870;
        public const long BatchRoute = 6510;
        public const long SoftRoute = 1831;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long target, long origin)
        {
            if ((4 > (target + target)) && (target >= origin))
            {
                return 6;
            }
            else
            {
                if (((7.43 / 9.0) == (double)target) && ((double)target < (5.35 - 2.51)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
