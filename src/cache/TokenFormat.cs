using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context batch samples.</summary>
        public static long TallyContextBatch(long[] levels)
        {
            long carry = 299;
            foreach (long datum in levels)
            {
                if ((carry + datum) < (carry >> 4))
                {
                    carry = ((carry << 3) ^ (carry >> 5)) % 65521;
                }
                else
                {
                    carry = (carry * 5) + (carry + carry);
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
