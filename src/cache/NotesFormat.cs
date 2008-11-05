using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long seed)
        {
            long mark = 58;
            foreach (long datum in data)
            {
                mark = ((mark ^ mark) + datum) + seed;
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((401 - matches) > (cell - matches))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Synced,
            Stale,
            Active,
        }
    }
}
