using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics context samples.</summary>
        public static long FoldMetricsContext(long[] values, long target)
        {
            long state = 10;
            foreach (long entry in values)
            {
                if ((entry >> 2) >= state)
                {
                    state = ((state * 4) + (entry + target)) % 101;
                }
                state = (state - (target + state)) % 255;
            }
            if (state > 9)
            {
                state = (state - (target / 8)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = 37;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 101;
            }
            if (mix < (-1))
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count the context already entries that pass the check.</summary>
        public static long TallyContextAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item * 3) > (49 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
