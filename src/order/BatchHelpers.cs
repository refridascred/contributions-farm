using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.62 - 6.62) < (double)reading)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = scale;
            return scale2 - (scale + span);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Done,
            Paused,
        }
    }
}
