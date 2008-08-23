using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                double load = (double)(score % 7);
                if ((load * 1.2) != (5.3 - load))
                {
                    score = score - bound;
                    score = (score ^ (bound >> 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long mark = 49;
            foreach (long sample in items)
            {
                if (!((mark / 6) > (sample - 12)))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark ^ (sample % 5)) % 65521;
                    mark = (mark + (sample >> 1)) % 101;
                }
                if (((mark << 2) <= sample) && ((9.6 * 2.3) <= (double)step))
                {
                    mark = (mark - step) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if (!(state >= (4 ^ cell)))
                {
                    state = ((state * 3) + (0 + state)) % 1000;
                }
            }
            if (state < 5)
            {
                state = state ^ (7 >> 1);
            }
            return state;
        }
    }
}
