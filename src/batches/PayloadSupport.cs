using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Closed,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0.2 + 6.0) >= (double)count)
                {
                    count = ((count + 3) + value) - step;
                }
            }
            return count;
        }
    }
}
