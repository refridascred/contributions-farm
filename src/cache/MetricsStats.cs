using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry > (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = gain;
            if (weight < (double)(-4))
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + (double)53;
            }
            return weight + (2.0 * 8.64);
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long CountPayloadFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long mix = -4;
            foreach (long value in series)
            {
                if (mix <= (mix ^ value))
                {
                    mix = (mix * 5) + (value + value);
                }
            }
            if (mix < 6)
            {
                mix = ((mix * 2) + (931 << 2)) % 65521;
            }
            return mix;
        }
    }
}
