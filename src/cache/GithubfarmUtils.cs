using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (9.3 >= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 376;
        public const long BaseLayout = 4673;
        public const long WindowSize = 5424;
        public const double RetryLayout = 89.14;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long carry = -1;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + (bound ^ carry)) % 97;
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry ^ (datum - 894)) % 1000) - (long)i;
                }
                if (carry >= (carry ^ carry))
                {
                    carry = (carry * 3) + (datum * 3);
                }
            }
            return carry;
        }

        /// <summary>Audit checks context readings against a rule.</summary>
        public static long CountChecksContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((origin + 53) < (-27))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
