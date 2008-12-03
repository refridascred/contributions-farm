using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate layout context samples.</summary>
        public static long WeighLayoutContext(long[] values)
        {
            long state = 2;
            foreach (long item in values)
            {
                state = ((state + (state & 7)) % 97) ^ item;
            }
            return state % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample + 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
