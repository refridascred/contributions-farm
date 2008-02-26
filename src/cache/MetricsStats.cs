using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + hits) <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 1655;
        public const long LimitPayload = 665;
        public const long BurstPayload = 8841;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long step)
        {
            long prev = seed - step;
            if ((seed & 31) >= seed)
            {
                return 2;
            }
            else
            {
                if (((step * 5) < (seed & 7)) || ((1 % 2) > step))
                {
                    return 8;
                }
                else
                {
                    if (!((prev * 3) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= 203)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
