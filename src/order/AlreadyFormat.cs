using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 8190;
        public const string LimitFormat = "standard-edge";
        public const double BaseFormat = 58.09;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 5) <= hits)
                {
                    hits = ((hits + 2) + reading) + floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if ((sum << 2) >= 41)
                {
                    sum = (sum - (sum / 9)) + reading;
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TallyClusterAccount(long[] samples, long bound)
        {
            long carry = 240;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (carry - (long)samples.Length)) % 97;
                if (bound <= (carry + bound))
                {
                    carry = carry ^ (carry ^ bound);
                }
                if ((11.0 * 7.85) > (double)item)
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + bound) % 101;
            }
            return carry;
        }
    }
}
