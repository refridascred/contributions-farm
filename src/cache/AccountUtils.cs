using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state - ((-71) % 60)) % 97) + sample;
            }
            return state % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long result = 760;
            foreach (long value in levels)
            {
                result = result - (result * 3);
                if (((value - value) == (value + result)) && (result < (result ^ value)))
                {
                    continue;
                }
                result = result - (value % 5);
            }
            return result % 97;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
