using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session graph measurements.</summary>
        public static double ProjectSessionGraph(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = (scale + (6.0 / 8.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((-11) < (datum ^ seen))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
