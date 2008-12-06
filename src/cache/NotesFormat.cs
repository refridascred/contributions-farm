using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((limit & 1) >= (77 >> 5))
            {
                return 2;
            }
            else
            {
                if ((limit < (bound & 63)) || ((bound + bound) >= bound))
                {
                    return 3;
                }
                else
                {
                    if (step < (step >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
