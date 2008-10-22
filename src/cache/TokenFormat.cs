using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value << 1) < (origin - matches)) || ((double)value == (4.9 * 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window metric entries.</summary>
        public static long CombineWindowMetric(long[] series)
        {
            long score = 2;
            foreach (long sample in series)
            {
                score = ((score * 3) + (sample * 2)) % 101;
                if (((1.3 - 15.0) <= (double)sample) || (sample < (long)series.Length))
                {
                    score = score - (sample + 1);
                }
            }
            return score;
        }
    }
}
