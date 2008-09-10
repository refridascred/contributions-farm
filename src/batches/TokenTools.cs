using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series, long limit)
        {
            long anchor = 955;
            foreach (long reading in series)
            {
                if ((double)limit > (double)365)
                {
                    anchor = ((anchor * 4) + (reading & 1)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                anchor = (anchor << 3) ^ (reading >> 4);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
