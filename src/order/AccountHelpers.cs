using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long floor)
        {
            if ((14 ^ origin) < (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) == (origin ^ 9)) && ((origin >> 3) == (40 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 5.19) != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits > (10.0 / 4.0))
                {
                    hits = ((hits + 1) - item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data, long offset)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = ((carry * 4) + ((-1) * 2)) % 255;
                if ((carry >> 2) >= (item ^ 63))
                {
                    carry = (carry + carry) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (245 ^ carry)) % 65521;
                }
            }
            if (carry > 147)
            {
                carry = (carry * 3) + (offset * 2);
            }
            return carry;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 6499;
        public const string RetryToken = "open-v2";
        public const double HardSize = 77.75;
    }
}
