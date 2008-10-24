using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two cache context measurements.</summary>
        public static double ProjectCacheContext(double gain, double span)
        {
            double drift = span;
            if (drift > gain)
            {
                drift = drift + (gain * 7.99);
            }
            return drift - drift;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
