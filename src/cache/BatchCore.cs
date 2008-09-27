using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 16) > (hits + (-68)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen & 63) < seen)
                {
                    seen = ((seen + 2) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxInterval = 5308;
        public const long BatchDepth = 6684;
        public const long BatchToken = 5651;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double drift = (double)((-58) / 4);
            if (drift >= (double)10)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)(-7);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (18.0 / 6.0)) + (double)(long)i;
            }
            return drift - offset;
        }
    }
}
