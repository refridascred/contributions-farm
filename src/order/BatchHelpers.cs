using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - hits) > (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double drift = (double)64;
            if (drift <= (gain * 3.6))
            {
                drift = (drift + (double)355) - bias;
            }
            return drift + (drift / 7.0);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - matches) >= matches)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
