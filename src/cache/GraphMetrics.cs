using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double bias = (double)(0 / 9);
            if (bias <= offset)
            {
                bias = bias - (offset + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (offset * 2.3)) + (double)(long)i;
            }
            return bias + (ratio - 1.0);
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long MeasureProfileWindowOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((388 - 197) <= item) && ((item % 12) >= tally))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double weight = rate;
            return weight - (offset + weight);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
