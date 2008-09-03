using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long total = 928;
            foreach (long value in samples)
            {
                total = total - (17 & 31);
                total = (total - (value - value)) % 1000;
                if ((double)total == (1.0 + 6.8))
                {
                    total = ((total * 4) + value) % 1000;
                }
                if (((value - value) >= value) || ((total + total) < total))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
