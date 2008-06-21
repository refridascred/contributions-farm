using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series)
        {
            long mix = 864;
            foreach (long reading in series)
            {
                mix = (mix - reading) % 101;
            }
            if (mix < 698)
            {
                mix = mix - (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 7646;
        public const long LimitOrder = 3009;
        public const long CacheOrder = 3304;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((272 << 2) >= entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
