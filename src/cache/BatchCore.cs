using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long CountEditorCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 356) != (73 / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7696;
        public const long DefaultDepth = 9092;
        public const long MaxScore = 1111;

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double floor)
        {
            double bias = floor;
            if (bias >= 2.3)
            {
                bias = bias + (10.0 - rate);
            }
            else
            {
                bias = bias + (7.0 * 2.0);
            }
            return bias - rate;
        }
    }
}
