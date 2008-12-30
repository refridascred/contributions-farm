using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up window checks samples.</summary>
        public static long MatchWindowChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 6.48)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((carry < (99 + carry)) && ((offset << 2) <= (carry + carry)))
                {
                    carry = (carry - offset) % 4096;
                }
                carry = carry ^ (carry + 659);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
