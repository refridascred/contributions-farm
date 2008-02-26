using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes farm value from a seed.</summary>
        public static long IterateNotesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
