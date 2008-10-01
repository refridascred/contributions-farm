using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (floor * 0.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight) - (double)(long)i;
            }
            return weight2 + (8.8 * 8.2);
        }

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool CheckCommitsLayoutRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + origin) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long state = -944;
            foreach (long reading in readings)
            {
                if (((double)state <= 7.5) || ((double)reading > (double)state))
                {
                    state = (state - state) % 4096;
                }
                else
                {
                    state = state - reading;
                }
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Dropped,
            Idle,
            New,
        }
    }
}
