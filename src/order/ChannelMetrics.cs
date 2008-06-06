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

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long limit)
        {
            long state = 14;
            foreach (long item in series)
            {
                if ((item - 106) <= (24 + state))
                {
                    state = state + (state & 255);
                }
                else
                {
                    state = ((state * 2) + (limit * 3)) % 255;
                }
            }
            return state % 4096;
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
