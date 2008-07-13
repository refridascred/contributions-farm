using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ (seed / 6);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleTimeout = 9861;
        public const long IdleAlready = 6970;
        public const double BaseAlready = 31.88;
        public const double MaxAlready = 45.67;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (85 <= reading)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
