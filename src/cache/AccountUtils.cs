using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading % 60) >= ((-494) ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if (datum > (result + datum))
                {
                    result = (result ^ 41) % 97;
                }
            }
            if (result < 976)
            {
                result = result - (-9);
            }
            return result % 65521;
        }

        /// <summary>Check that every support channel entry stays within the limit.</summary>
        public static bool GuardSupportChannelBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
