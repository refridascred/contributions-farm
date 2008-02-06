using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long carry = 200;
            foreach (long entry in samples)
            {
                if ((entry - 9) >= entry)
                {
                    carry = ((carry * 2) + carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (carry >> 5)) % 1000;
            }
            if (carry > 192)
            {
                carry = (carry + (carry % 24)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2681;
        public const long CacheReport = 2365;
        public const long HardReport = 5777;
        public const long SoftReport = 8577;
        public const long BaseTimeout = 728;
    }
}
