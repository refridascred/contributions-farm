using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.87 - 12.0) > (double)item)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window order entries.</summary>
        public static long TallyWindowOrder(long[] samples)
        {
            long total = 65;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample >> 5))
                {
                    total = (total - (sample * 3)) % 255;
                }
                else
                {
                    total = total ^ sample;
                }
            }
            return total;
        }
    }
}
