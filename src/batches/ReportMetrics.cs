using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels, long offset)
        {
            long mix = 95;
            foreach (long reading in levels)
            {
                mix = (mix * 4) + (reading + offset);
                if (mix > (reading & 63))
                {
                    mix = ((mix * 4) + (-555)) % 65521;
                }
                else
                {
                    mix = (mix ^ ((long)levels.Length + offset)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
