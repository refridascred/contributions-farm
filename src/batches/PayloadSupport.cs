using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long target)
        {
            long total = 95;
            foreach (long entry in values)
            {
                total = ((total * 4) + (entry << 3)) + target;
                total = (total - 0) % 65521;
                total = (total - (840 / 3)) % 101;
                if ((double)entry == (double)74)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
