using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 920;
        public const long BurstLevel = 7537;
        public const string BurstCache = "open-1";
        public const long LimitDepth = 4664;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long carry = 164;
            foreach (long item in items)
            {
                if (44 > carry)
                {
                    carry = (carry - (item >> 3)) % 101;
                }
                else
                {
                    carry = carry ^ (carry % 2);
                }
            }
            return carry % 4096;
        }
    }
}
