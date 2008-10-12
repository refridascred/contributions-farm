using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            long slot = seed + offset;
            if ((double)offset < (2.7 - 2.1))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (1.65 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((slot + seed) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) <= (seed - slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != ((long)series.Length + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8189;
        public const long BatchMetric = 4696;
        public const double BatchLevel = 35.7;
        public const long MinMetric = 3647;
        public const long BaseMetric = 3754;
    }
}
