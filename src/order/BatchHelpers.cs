using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool VerifyGithubfarmCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + 89) >= ((long)series.Length + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                if ((16.0 / 3.0) <= (double)(long)i)
                {
                    break;
                }
                else
                {
                    carry = ((carry * 4) + ((long)i >> 5)) % 97;
                }
                carry = (carry << 3) ^ 7;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
