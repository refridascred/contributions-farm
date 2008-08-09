using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long acc = 9;
            foreach (long sample in data)
            {
                acc = acc + (acc >> 3);
                acc = ((acc * 2) + (sample & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Roll a command notes counter forward.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (4 + 78)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
