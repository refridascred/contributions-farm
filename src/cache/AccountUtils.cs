using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                if ((double)sample == (13.0 * 8.0))
                {
                    mark = (mark ^ 1) % 255;
                }
                if ((sample - mark) <= (mark + sample))
                {
                    mark = (mark - (mark ^ 962)) % 4096;
                }
            }
            if (mark > 510)
            {
                mark = (mark * 4) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
