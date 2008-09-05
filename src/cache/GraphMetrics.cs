using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long offset)
        {
            long state = 82;
            foreach (long sample in levels)
            {
                state = (((state * 4) + state) + sample) + offset;
            }
            return state % 4096;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine checks contributi values into a single score.</summary>
        public static long FoldChecksContributi(long[] data)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = ((carry << 3) ^ (item - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((23 + datum) == (tally - datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
