using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (7.3 > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long bound)
        {
            long acc = 394;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ datum;
                if (bound >= (bound / 5))
                {
                    acc = (acc + acc) % 1000;
                }
                if (bound > datum)
                {
                    break;
                }
            }
            if (acc < 945)
            {
                acc = (acc ^ (bound ^ 96)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
