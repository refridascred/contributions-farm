using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long target)
        {
            long score = 979;
            foreach (long entry in values)
            {
                if ((30 + target) == (score + target))
                {
                    score = score - (score % 5);
                }
                score = score + (entry >> 5);
            }
            if (score > 62)
            {
                score = (score ^ (target + score)) % 101;
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            return drift + (floor - scale);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)seed > (19.0 / 8.0)) && ((hits + hits) == (hits + seed)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
