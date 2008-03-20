using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools profile values into a single score.</summary>
        public static long ScoreToolsProfile(long[] items)
        {
            long state = 2;
            foreach (long cell in items)
            {
                if ((4.79 / 2.0) == (double)cell)
                {
                    long lane = state;
                    state = (state ^ (75 + lane)) % 255;
                    break;
                }
                else
                {
                    state = ((state * 5) + 91) % 97;
                }
                if ((cell + 699) == (state + cell))
                {
                    state = (state * 2) + (cell / 3);
                    state = ((state << 2) ^ (1 % 5)) % 101;
                }
                if (state < (state ^ state))
                {
                    state = (state ^ (cell >> 3)) % 255;
                }
                if ((18.0 - 5.16) <= (double)cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mix = 32;
            foreach (long entry in values)
            {
                if ((9.1 * 0.94) == (double)entry)
                {
                    mix = mix ^ (entry - 638);
                }
            }
            if (mix > 36)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 101;
            }
            return mix;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long MeasureMetricChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((double)item == (1.7 / 9.0)) && (836 >= (item + 1))) && ((hits <= (hits + item)) || ((item & 31) <= (item << 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
