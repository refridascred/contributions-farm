using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count graph route pairs that satisfy a relation.</summary>
        public static long PairGraphRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long CombineFilterSupport(long[] items, long bound)
        {
            long result = -326;
            foreach (long datum in items)
            {
                if ((792 + datum) < (result - 537))
                {
                    result = (result - (bound >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Closed,
            Paused,
        }
    }
}
