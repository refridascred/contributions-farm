using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up window route samples.</summary>
        public static long MatchWindowRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double mean = 3.0 + (double)97;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean - (7.8 / 5.0)) + (double)(long)i) + ratio) + floor;
            }
            return mean - 4.38;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + datum) >= hits)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
