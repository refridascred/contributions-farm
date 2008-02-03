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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample ^ matches) != (sample & 31))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
