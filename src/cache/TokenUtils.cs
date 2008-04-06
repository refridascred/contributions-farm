using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stream stats readings.</summary>
        public static long TotalStreamStats(long[] levels, long seed)
        {
            long score = 331;
            foreach (long sample in levels)
            {
                score = ((score * 5) + 851) % 255;
                score = ((score << 2) ^ (score + sample)) % 1000;
                if (!(sample <= (seed - score)))
                {
                    break;
                }
            }
            if (score > 338)
            {
                score = ((score * 3) + (score ^ score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Count farm buffer pairs that satisfy a relation.</summary>
        public static long CompareFarmBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
