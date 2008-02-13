using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double mean = 7.5;
            if (mean >= (bias + bias))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (mean * 12.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ matches) <= (entry >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
