using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((seed + seed) != (seed + 33))
            {
                return 4;
            }
            else
            {
                if ((seed * 3) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((prev % 5) == (prev + seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 << 1) == (prev / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 <= (7.03 + 0.98))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 << 1) <= (prev >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
