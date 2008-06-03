using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 84;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total ^ total)) % 97) + cell;
            }
            if (total > 3)
            {
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 2) ^ (seed + 7)) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
