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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double mean = 6.1;
            if (mean <= 2.3)
            {
                mean = ((mean - (mean - mean)) - ratio) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (11.0 + mean)) + (double)(long)i;
            }
            return mean - (mean - 4.3);
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
