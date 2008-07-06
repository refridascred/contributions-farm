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

        /// <summary>Combine context entry values into a single score.</summary>
        public static long TotalContextEntry(long[] samples)
        {
            long mix = 444;
            foreach (long value in samples)
            {
                if ((value >= (mix ^ mix)) && ((1.97 / 8.0) < (double)mix))
                {
                    mix = (mix << 3) ^ value;
                    mix = ((mix << 3) ^ value) % 255;
                }
                else
                {
                    mix = mix + (514 << 2);
                }
                mix = ((mix * 5) + (value + mix)) % 1000;
                mix = mix + mix;
            }
            return mix % 4096;
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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 5656;
        public const long CacheRatio = 2864;
        public const double BurstRecord = 92.05;
    }
}
