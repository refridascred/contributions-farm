using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next order layout value from a seed.</summary>
        public static long IterateOrderLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i ^ acc) < 12)
                {
                    acc = (acc ^ 58) % 65521;
                    acc = (acc - (660 + 7)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc + (seed - seed)) % 97) ^ (long)i2;
                }
                if ((seed - 1) < ((long)i - (long)i))
                {
                    acc = (acc + (acc % 7)) % 1000;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
