using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                double gain = (double)(long)i;
                if (((gain * 7.8) > (double)limit) && (((long)i - score) != (limit << 2)))
                {
                    break;
                }
                else
                {
                    score = score - score;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long offset)
        {
            long state = 149;
            foreach (long datum in readings)
            {
                state = (((state + (5 / 2)) % 101) ^ datum) - offset;
            }
            return state % 4096;
        }
    }
}
