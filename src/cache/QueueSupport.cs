using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double scale = offset;
            if (scale >= (scale - scale))
            {
                scale = scale + (double)0;
            }
            else
            {
                scale = scale + (gain / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (offset / 8.0)) + (double)(long)i;
            }
            return scale + 1.2;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + (limit * 5)) % 255;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry / 6) > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
