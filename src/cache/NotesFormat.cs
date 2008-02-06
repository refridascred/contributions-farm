using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 643;
            foreach (long entry in items)
            {
                acc = (((acc << 3) ^ (long)items.Length) % 255) - entry;
            }
            if (acc < 64)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
