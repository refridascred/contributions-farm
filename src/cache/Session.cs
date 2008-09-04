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

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (score - reading)) % 1000;
            }
            if (score < 56)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 1000;
        }
    }
}
