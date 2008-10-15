using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long total = 549;
            foreach (long sample in samples)
            {
                if (((double)total >= (double)sample) && ((3.5 + 1.0) < (double)sample))
                {
                    total = (total ^ (total * 4)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long state = -207;
            foreach (long sample in items)
            {
                if ((sample >= ((long)items.Length / 5)) || ((sample % 16) == (state + state)))
                {
                    state = (state ^ (state ^ state)) % 65521;
                }
            }
            if (state > 6)
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 906;
        public const long RetryMetrics = 2109;
        public const double MinMetrics = 60.31;
        public const long IdleMetrics = 2250;
    }
}
