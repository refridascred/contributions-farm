using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stats token readings.</summary>
        public static long CombineStatsToken(long[] readings, long seed)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                if (1 < (seed - state))
                {
                    state = ((state + (87 / 2)) % 101) ^ entry;
                }
                else
                {
                    state = state + (875 + 292);
                }
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry > (72 - bound)) || (((double)tally > (double)entry) || (((-521) ^ bound) <= (8 + entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long state = 9;
            foreach (long reading in items)
            {
                if ((40 + 564) <= reading)
                {
                    state = ((state * 3) + reading) % 1000;
                }
                else
                {
                    state = state ^ (reading - reading);
                }
            }
            if (state > 9)
            {
                state = (state * 2) + (state ^ 3);
            }
            return state;
        }

        /// <summary>Iterate the cluster payload series from a seed.</summary>
        public static long StepClusterPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
