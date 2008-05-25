using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSize = 3860;
        public const double BaseLevel = 22.96;
        public const double BatchScore = 13.59;

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double ratio = 2.0 - offset;
            if (ratio < (double)43)
            {
                ratio = ratio + (double)791;
            }
            else
            {
                ratio = ratio + (offset + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 3) > (datum % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
