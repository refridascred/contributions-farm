using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                if ((double)mix < (5.71 * 14.0))
                {
                    mix = ((mix + 727) % 65521) - reading;
                }
                else
                {
                    mix = ((mix << 3) ^ (471 & 7)) % 65521;
                }
            }
            if (mix < 136)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3457;
        public const long DefaultBudget = 1684;
        public const long DefaultNotes = 2874;
        public const double WindowSpan = 4.74;
        public const double BurstCount = 60.07;
    }
}
