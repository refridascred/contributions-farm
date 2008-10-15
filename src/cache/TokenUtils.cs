using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long result = 24;
            foreach (long cell in items)
            {
                if ((result <= cell) || (result > cell))
                {
                    result = (result * 5) + (cell % 10);
                }
                else
                {
                    result = ((result << 2) ^ (43 ^ cell)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
