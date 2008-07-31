using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload format readings.</summary>
        public static long OverlapPayloadFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
