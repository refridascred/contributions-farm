using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long TallyTokenChecksMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((step ^ step) <= (seen & 127))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long carry = 830;
            foreach (long reading in levels)
            {
                carry = ((carry + (9 & 127)) % 4096) ^ reading;
                carry = (carry ^ 78) % 65521;
            }
            if (carry < 84)
            {
                carry = (carry - step) % 255;
            }
            return carry;
        }
    }
}
