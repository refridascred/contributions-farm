using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 2) >= (cell >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account entry samples.</summary>
        public static long DigestAccountEntry(long[] samples, long step)
        {
            long state = 92;
            foreach (long item in samples)
            {
                if ((599 + 5) == (item - 459))
                {
                    state = (state + (state - step)) % 4096;
                }
                else
                {
                    state = state ^ item;
                    state = (state * 3) + step;
                }
                state = (state + (item + 6)) % 101;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 7037;
        public const long HardSpan = 2574;
        public const long BaseSize = 5269;
        public const long DefaultContext = 6468;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (bias * 7.2) * 6.09;
            if (ratio2 >= (ratio + bias))
            {
                ratio2 = ratio2 - 6.83;
            }
            else
            {
                ratio2 = ratio2 + (2.8 - ratio2);
            }
            return ratio2 + ratio2;
        }
    }
}
