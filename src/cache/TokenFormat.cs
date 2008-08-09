using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long origin)
        {
            long anchor = 376;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 97) + origin;
                if ((double)sample <= (2.39 + 2.3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long anchor = -121;
            foreach (long reading in samples)
            {
                if ((reading & 63) == (anchor / 5))
                {
                    anchor = ((anchor * 4) + (reading + 278)) - offset;
                }
                else
                {
                    anchor = (anchor + reading) % 97;
                }
            }
            if (anchor < (-357))
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Idle,
            Ready,
        }
    }
}
