using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (result % 10)) % 101;
                if (((double)value < (20.0 / 5.0)) || ((result / 6) > value))
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of queue entry readings.</summary>
        public static long OverlapQueueEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
