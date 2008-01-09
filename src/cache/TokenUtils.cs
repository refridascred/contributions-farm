using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = -199;
            foreach (long datum in samples)
            {
                if (datum > (datum ^ 5))
                {
                    mark = ((mark * 5) + (mark ^ mark)) % 101;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ 15;
            }
            return mark;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
