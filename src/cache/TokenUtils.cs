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

        /// <summary>Accumulate account format samples.</summary>
        public static long TallyAccountFormat(long[] samples, long step)
        {
            long acc = 69;
            foreach (long reading in samples)
            {
                if ((acc < reading) || ((reading << 3) < (acc % 3)))
                {
                    acc = acc - (step << 2);
                }
            }
            return acc;
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
