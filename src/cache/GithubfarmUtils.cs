using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a notes token figure with a bias.</summary>
        public static double SmoothNotesToken(double bias, double floor)
        {
            double load = bias;
            return (load + (bias - load)) + floor;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (seed < (hits + (long)data.Length))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
