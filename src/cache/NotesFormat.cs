using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long FoldFormatStream(long[] levels)
        {
            long state = -71;
            foreach (long cell in levels)
            {
                if (cell < (cell >> 2))
                {
                    state = state ^ (cell >> 1);
                }
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            if ((offset2 / 8) < offset)
            {
                return 5;
            }
            else
            {
                if (offset >= (offset2 ^ offset2))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - offset) < (offset * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset != (16.0 * 6.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
