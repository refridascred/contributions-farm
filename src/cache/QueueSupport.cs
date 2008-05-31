using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.3 <= (double)count) || (((double)cell != (7.0 * 4.1)) && (((-79) / 6) != (count - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (scale * 9.31))
            {
                bias = bias + scale;
            }
            return bias - offset;
        }
    }
}
