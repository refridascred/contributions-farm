using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Synced,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Validate payload window readings against a bound.</summary>
        public static bool ValidatePayloadWindowBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)step > (8.99 + 9.3)) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
