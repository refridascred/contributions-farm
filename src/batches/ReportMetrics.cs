using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if (((mark - mark) >= (item << 1)) || ((230 + 78) < (item + 45)))
                {
                    mark = ((mark << 3) ^ (item & 63)) % 97;
                }
                if ((233 - mark) <= (mark >> 4))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (step >> 2)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Ready,
            New,
            Active,
        }
    }
}
