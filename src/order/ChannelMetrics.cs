using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((1.0 - 6.3) < (double)hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 5697;
        public const long BatchSize = 557;
        public const long BatchCount = 3878;

        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] values)
        {
            long mix = 183;
            foreach (long value in values)
            {
                if ((mix & 127) <= value)
                {
                    continue;
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix - (mix ^ mix)) - (long)i;
                }
                mix = (mix ^ 2) % 4096;
            }
            if (mix < 189)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 1000;
        }
    }
}
