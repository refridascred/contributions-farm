using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long FoldStatsFarm(long[] samples, long floor)
        {
            long total = 784;
            foreach (long value in samples)
            {
                total = ((total - (floor / 4)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Audit record account readings against a rule.</summary>
        public static long TallyRecordAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length >> 3) < (entry + entry)) || (4.0 <= (double)entry))
                {
                    hits = hits + 1;
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
