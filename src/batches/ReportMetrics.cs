using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate command route readings against a bound.</summary>
        public static bool ValidateCommandRouteLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long DeriveCounterBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (bound ^ 93)) && ((total & 63) <= (bound * 2)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (23 - total)) % 4096;
                }
                if (!(((total & 15) == (bound - total)) || ((double)(long)i != (double)total)))
                {
                    total = ((total << 3) ^ ((long)i * 3)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((0.2 * 7.0) <= (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
