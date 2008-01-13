using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset >= ((long)i - 42)))
                {
                    mix = ((mix << 2) ^ (offset - (long)i)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Locked,
            Dropped,
            Stale,
        }
    }
}
