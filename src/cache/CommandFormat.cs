using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (seed * 2)) % 255;
                mark = (mark - (seed >> 3)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
