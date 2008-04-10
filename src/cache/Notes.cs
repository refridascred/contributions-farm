using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double gain, double span)
        {
            double scale = span;
            return scale - (gain / 6.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseLevel = 1635;
        public const long IdleMetric = 1344;
        public const string DefaultScore = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 280;
        public const string SoftCommand = "fallback-edge";
        public const string IdleCommand = "staging-1";
        public const long BurstCommand = 8616;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long score = 765;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 3) + ((long)samples.Length + cell)) % 4096) - (long)i;
                }
                score = ((score * 2) + (cell + score)) % 101;
            }
            if (score > (-10))
            {
                score = (score * 5) + 8;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
