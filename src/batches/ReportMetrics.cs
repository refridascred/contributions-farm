using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8301;
        public const long MinStream = 1358;
        public const long DefaultRatio = 5913;
        public const long WindowStream = 3906;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long state = 276;
            foreach (long reading in series)
            {
                if (((double)state < (12.0 * 3.0)) || (reading > (reading - reading)))
                {
                    state = ((state * 3) + (state ^ (long)series.Length)) % 65521;
                }
                else
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
