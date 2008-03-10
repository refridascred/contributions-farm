using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long floor)
        {
            long prev = bound + floor;
            if ((floor + floor) > (prev >> 3))
            {
                return 3;
            }
            else
            {
                if (((9 ^ prev) != (prev - floor)) && ((double)floor > (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((-92) & 63) == (bound - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + limit) != (47 + limit))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "latest-v2";
        public const double StepBatches = 32.64;
        public const long RetryBatches = 7530;
    }
}
