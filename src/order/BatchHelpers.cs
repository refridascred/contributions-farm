using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item >> 4) >= item) || ((double)item > (0.7 / 6.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account channel entries.</summary>
        public static long CombineAccountChannel(long[] series, long limit)
        {
            long result = 55;
            foreach (long reading in series)
            {
                if ((limit - result) > (limit >> 2))
                {
                    continue;
                }
                if (reading > (result >> 3))
                {
                    result = (result + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
