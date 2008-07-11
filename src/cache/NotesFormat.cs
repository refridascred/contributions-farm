using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Queued,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] readings, long offset)
        {
            long state = 580;
            foreach (long item in readings)
            {
                state = (((state ^ 82) % 101) + item) - offset;
            }
            if (state < (-437))
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long limit)
        {
            long anchor = 84;
            foreach (long item in data)
            {
                if ((double)item < (13.0 / 2.0))
                {
                    anchor = ((anchor << 3) ^ limit) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + limit;
                    anchor = ((anchor << 3) ^ (75 ^ 776)) % 101;
                }
                anchor = anchor + item;
                if (anchor <= 14)
                {
                    anchor = (anchor + (anchor << 3)) % 255;
                }
            }
            if (anchor < 165)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
