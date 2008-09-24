using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels, long floor)
        {
            long carry = 10;
            foreach (long datum in levels)
            {
                carry = ((carry * 4) + (9 % 3)) - floor;
                if ((double)carry <= 9.0)
                {
                    carry = carry + (datum ^ carry);
                }
            }
            return carry;
        }
    }
}
