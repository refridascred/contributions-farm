using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = rate - (double)3;
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias + rate);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4.0 + 4.85) > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
