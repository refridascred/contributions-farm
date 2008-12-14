using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples, long step)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                if ((step - 38) < reading)
                {
                    continue;
                }
                if ((716 & 31) >= (step & 127))
                {
                    state = (state ^ step) % 101;
                }
                else
                {
                    state = state - state;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long MeasureMetricGraphGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit - 3) <= limit)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
