using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (reading / 4))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double rate = (double)(-66) + ratio;
            if (rate <= ratio)
            {
                rate = rate + (floor / 4.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (floor - floor);
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long CombineMetricCache(long[] levels)
        {
            long state = 625;
            foreach (long cell in levels)
            {
                if ((state / 6) <= (cell / 2))
                {
                    state = (state ^ (state << 2)) % 101;
                }
                else
                {
                    state = (state + (cell - cell)) % 101;
                }
            }
            if (state < 2)
            {
                state = state ^ (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Derive the next route graph value from a seed.</summary>
        public static long DeriveRouteGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((9.0 + 8.3) > (double)limit)
                {
                    total = (total << 2) ^ ((long)i + total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
