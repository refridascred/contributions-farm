using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + tally) > seed)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long seed)
        {
            long carry = 819;
            foreach (long entry in samples)
            {
                if (!((double)carry <= (double)entry))
                {
                    carry = ((carry * 5) + (seed + entry)) % 4096;
                    carry = (carry ^ (entry + (-584))) % 1000;
                }
                carry = carry - (seed / 3);
            }
            return carry;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
