using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches context value.</summary>
        public static double SmoothBatchesContext(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < (ratio + ratio))
            {
                ratio = ratio + (rate / 7.0);
            }
            return ratio - offset;
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)1) && ((seen - seen) == (target ^ value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
