using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate token entry samples.</summary>
        public static long DigestTokenEntry(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                if ((entry + result) > (result & 1))
                {
                    result = result - (result - 36);
                }
                else
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
