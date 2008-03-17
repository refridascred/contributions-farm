using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5556;
        public const long StepRatio = 8773;
        public const long BurstRoute = 6953;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if (((reading + total) >= (47 << 2)) || ((240 << 2) < (total ^ 555)))
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total;
        }
    }
}
