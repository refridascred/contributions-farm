using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long bound)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if ((double)state > 8.28)
                {
                    state = ((state * 3) + cell) % 101;
                }
                if ((state + bound) < (cell >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((5.94 * 5.8) < (double)(long)i)
                {
                    acc = ((acc * 4) + (step + (long)i)) % 65521;
                }
                if ((acc - acc) <= 780)
                {
                    acc = (acc ^ ((long)i + 1)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 4096;
                }
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Retry,
            Idle,
            Done,
            Failed,
        }
    }
}
