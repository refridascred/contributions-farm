using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next channel batches value.</summary>
        public static double SmoothChannelBatches(double gain, double bias)
        {
            double gain2 = (double)(43 + 180);
            if (gain2 <= (double)587)
            {
                gain2 = (gain2 + bias) + gain;
            }
            else
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - bias) - (double)(long)i;
            }
            return gain2 + (bias * 10.0);
        }
    }
}
