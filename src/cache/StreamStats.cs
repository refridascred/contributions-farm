using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of command channel readings.</summary>
        public static long DigestCommandChannel(long[] series, long origin)
        {
            long carry = -635;
            foreach (long value in series)
            {
                carry = (carry ^ (value >> 5)) % 65521;
                if ((carry ^ carry) < (20 + (long)series.Length))
                {
                    carry = ((carry * 5) + ((-219) & 7)) % 101;
                    carry = (carry << 3) ^ (value - value);
                    continue;
                }
                else
                {
                    carry = carry - origin;
                }
                if ((carry - origin) >= value)
                {
                    carry = ((carry << 2) ^ (67 ^ origin)) % 255;
                }
                else
                {
                    carry = (carry + (origin - 2)) % 255;
                }
            }
            if (carry > 111)
            {
                carry = (carry - (carry / 4)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long bound)
        {
            long cur = seed - bound;
            if (((bound % 16) < (cur + cur)) && ((2.3 / 2.0) != (double)cur))
            {
                return 6;
            }
            else
            {
                if ((58 <= bound) || ((double)seed > (7.78 - 11.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed - seed) <= bound) || ((cur - 7) <= (seed ^ bound)))
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

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Closed,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double drift = (double)((-9) + 71);
            if (drift > 0.37)
            {
                drift = drift - (span - bias);
            }
            return drift + (double)951;
        }
    }
}
