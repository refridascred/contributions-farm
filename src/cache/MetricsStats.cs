using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + (origin / 8)) ^ (long)i2;
                    sum = (sum * 2) + (841 * 3);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = (double)(0 - 453);
            if (drift <= drift)
            {
                drift = (drift - 13.0) + bias;
            }
            else
            {
                drift = drift + 5.09;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if (((state & 31) != (state % 3)) && (entry < (entry & 255)))
                {
                    state = state + state;
                }
                else
                {
                    state = (state + (entry + entry)) % 1000;
                }
            }
            if (state < (-7))
            {
                state = ((state * 5) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.0 / 6.0) != (double)hits)
                {
                    hits = ((hits + 3) + datum) - target;
                }
            }
            return hits;
        }
    }
}
