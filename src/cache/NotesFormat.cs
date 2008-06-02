using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((offset * 3) != (offset + edge))
            {
                return 4;
            }
            else
            {
                if ((edge ^ edge) != (1 % 24))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 4) <= edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit + limit) < (edge + offset)) || ((13.0 - 19.0) >= (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchInterval = 5867;
        public const long IdleFactor = 4967;
        public const string WindowRecord = "legacy";
        public const double WindowSpan = 40.28;
        public const long LimitWidth = 8208;
    }
}
