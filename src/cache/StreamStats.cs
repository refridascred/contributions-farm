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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + mark) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
