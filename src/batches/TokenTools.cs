using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - item) > (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine route stream values into a single score.</summary>
        public static long DigestRouteStream(long[] levels)
        {
            long carry = 113;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry - (carry & 63)) % 255) + (long)i) ^ sample;
                }
                carry = (carry * 2) + (carry ^ carry);
            }
            if (carry > 98)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value < (2.71 + 9.0))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
