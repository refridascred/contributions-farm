using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long carry = -60;
            foreach (long entry in data)
            {
                if ((double)carry <= (4.65 + 4.62))
                {
                    long edge = carry;
                    carry = (carry * 4) + (carry ^ edge);
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry >> 1)) % 97;
                }
                if ((entry % 3) >= (entry + carry))
                {
                    carry = (carry - (carry << 3)) % 65521;
                }
                else
                {
                    carry = (carry + (5 * 2)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 1) <= (limit ^ 1))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
