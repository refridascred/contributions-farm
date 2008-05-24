using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mark = 297;
            foreach (long value in levels)
            {
                if ((mark % 16) >= mark)
                {
                    mark = (mark - (mark + 71)) + value;
                }
                else
                {
                    mark = mark ^ (mark % 7);
                }
            }
            if (mark < 98)
            {
                mark = mark ^ (965 * 2);
            }
            return mark % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((limit << 1) < matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long DigestCounterStream(long[] levels)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((carry ^ (874 / 4)) % 255) + value;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}
