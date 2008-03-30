using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 4) <= (datum + datum))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits <= (hits % 7)) && (((70 << 2) >= (hits / 6)) && ((9.7 + 1.0) != (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (drift + gain)) + (double)(long)i) + offset;
            }
            return drift + 2.5;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((offset % 64) < sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
