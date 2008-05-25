using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a farm order reading by value.</summary>
        public static long FindFarmOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (((state / 9) != (state / 4)) || ((state << 2) >= (state - 686)))
                {
                    state = state - (state + sample);
                }
                else
                {
                    state = (state << 3) ^ (sample - state);
                }
            }
            return state;
        }
    }
}
