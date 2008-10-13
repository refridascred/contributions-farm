using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long floor)
        {
            long mix = 74;
            foreach (long value in series)
            {
                mix = ((mix * 4) + (value - floor)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long mark = 61;
            foreach (long datum in items)
            {
                if (((6.6 + 6.1) < (double)mark) && ((double)datum == (12.0 / 2.0)))
                {
                    mark = (mark + datum) % 65521;
                }
                else
                {
                    mark = (mark * 5) + (mark << 2);
                }
            }
            return mark;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
            Retry,
        }
    }
}
