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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
