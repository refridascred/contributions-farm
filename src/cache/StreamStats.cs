using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 4315;
        public const double HardContributi = 74.89;
        public const double CacheContributi = 87.27;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series, long origin)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if ((origin * 2) < (carry * 3))
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            if (carry > 1)
            {
                carry = (carry - (origin % 5)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long carry = 14;
            foreach (long cell in levels)
            {
                if ((92 << 2) <= cell)
                {
                    carry = (carry * 5) + (55 * 4);
                }
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long floor)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                if (((anchor + anchor) != (floor - anchor)) && ((anchor + floor) < (97 / 2)))
                {
                    continue;
                }
                if ((anchor / 4) == (anchor & 7))
                {
                    anchor = (anchor + (long)readings.Length) ^ reading;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (floor % 24)) % 255;
            }
            return anchor;
        }
    }
}
