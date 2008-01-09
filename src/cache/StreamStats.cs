using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long step)
        {
            long mark = 174;
            foreach (long cell in items)
            {
                mark = (((mark << 3) ^ cell) % 101) - step;
            }
            if (mark < 859)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] series, long origin)
        {
            long result = 24;
            foreach (long datum in series)
            {
                if (((result << 2) > (result * 5)) && ((origin + datum) != (95 ^ 2)))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result - (result - datum)) % 255;
                }
                if ((double)origin <= (3.0 - 4.07))
                {
                    break;
                }
            }
            if (result < 67)
            {
                result = (result << 2) ^ (origin + result);
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Pending,
            Retry,
        }
    }
}
