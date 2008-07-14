using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state / 5)) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long offset, long step)
        {
            if ((double)89 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) > (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((step & 31) == (599 / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step <= (offset + 49)) || ((offset & 7) > (step + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 34.0;
        public const double LimitNotes = 46.06;
        public const long WindowTimeout = 6438;
        public const double BatchNotes = 36.39;
        public const string CacheDepth = "open-edge";
    }
}
