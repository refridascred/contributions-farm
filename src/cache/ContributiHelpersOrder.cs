using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((offset + count) <= count) && ((2.53 * 6.4) != (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit batches metric readings against a rule.</summary>
        public static long AuditBatchesMetricMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((322 - count) < bound)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
