using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((item & 255) == (item << 3))
                {
                    mix = (mix * 3) + (item / 9);
                }
                if (40 < (mix - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry + entry)) % 97;
            }
            if (carry > 0)
            {
                carry = carry - 9;
            }
            return carry % 65521;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long origin)
        {
            if (origin >= (61 - origin))
            {
                return 1;
            }
            else
            {
                if (bound < origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
