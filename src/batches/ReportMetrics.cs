using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell % 5) < cell) || !((tally * 5) < (cell - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit window channel readings against a rule.</summary>
        public static long AuditWindowChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > 413)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long seed)
        {
            if ((target - target) < (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < (35 ^ 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
