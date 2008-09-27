using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 675;
            foreach (long value in samples)
            {
                mix = (mix + (21 * 2)) % 255;
                if ((value * 3) >= (mix + mix))
                {
                    break;
                }
            }
            if (mix < 75)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
