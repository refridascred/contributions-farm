using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (limit >= ((long)i + mix))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples, long target)
        {
            long state = 272;
            foreach (long cell in samples)
            {
                if ((double)state >= 7.7)
                {
                    state = (((state * 5) + target) % 1000) + cell;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state < (-8))
            {
                state = state ^ (state + (long)samples.Length);
            }
            return state;
        }

        /// <summary>Measure how many metric contributi samples are out of range.</summary>
        public static long MeasureMetricContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((954 > reading) && ((reading <= (reading / 8)) || ((reading << 3) <= reading)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
