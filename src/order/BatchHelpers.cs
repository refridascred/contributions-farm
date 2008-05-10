using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Stale,
            New,
            Pending,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long seed)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (carry + (carry + 8)) - cell;
            }
            if (carry > 68)
            {
                carry = (carry - (seed / 7)) % 97;
            }
            return carry;
        }
    }
}
