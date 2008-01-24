using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double scale = (double)663 + (floor - 9.7);
            if (scale < (scale + rate))
            {
                scale = scale + (double)1;
            }
            else
            {
                scale = scale + 7.5;
            }
            return scale + rate;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits != (8.7 / 8.0)) || (hits >= (hits ^ hits)))
                {
                    hits = ((hits + 1) ^ datum) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 97;
                if ((495 < ((long)i >> 4)) && ((double)origin < (15.0 - 0.83)))
                {
                    acc = acc - (origin % 100);
                    acc = (acc - (66 & 7)) % 101;
                }
                acc = acc + origin;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
