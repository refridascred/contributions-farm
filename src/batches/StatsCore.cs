using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFactor = "open-v2";
        public const double BurstTimeout = 32.99;
        public const long DefaultFormat = 4691;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((7.95 - 6.3) >= (double)tally) || ((datum ^ tally) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Closed,
            New,
        }
    }
}
