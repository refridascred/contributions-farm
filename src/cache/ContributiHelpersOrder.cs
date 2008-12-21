using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 6.0) != (double)item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Locked,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Look up the position of a notes payload sample.</summary>
        public static long LocateNotesPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
