using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (6 / 5)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long LookupTokenRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
