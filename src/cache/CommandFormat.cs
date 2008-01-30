using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc - (504 * 5)) % 65521;
                if (((8.5 * 8.95) >= (double)acc) || ((cell + cell) > (cell % 100)))
                {
                    acc = (acc - (acc >> 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long DigestClusterSession(long[] data, long offset)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - (mix & 31)) + item) + offset;
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (mix / 9)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Draft,
            Paused,
            Ready,
            Locked,
        }
    }
}
