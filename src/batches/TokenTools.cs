using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate format entry samples.</summary>
        public static long DigestFormatEntry(long[] items, long floor)
        {
            long mix = -32;
            foreach (long reading in items)
            {
                mix = ((((mix << 3) ^ (3 & 127)) % 4096) ^ reading) + floor;
            }
            if (mix > 589)
            {
                mix = (mix * 2) + (mix % 16);
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Locate a profile entry reading by value.</summary>
        public static long SeekProfileEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
