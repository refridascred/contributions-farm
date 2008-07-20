using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values, long floor)
        {
            long state = 72;
            foreach (long cell in values)
            {
                if ((4.0 <= (double)floor) || (17 >= (state - (-680))))
                {
                    state = state ^ (state + cell);
                    continue;
                }
                if ((4.23 - 5.1) == (double)state)
                {
                    state = ((state << 2) ^ floor) % 1000;
                }
                else
                {
                    state = ((state * 3) + 52) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long CombineProfileGithubfarm(long[] values, long origin)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if ((cell % 12) <= (6 - 21))
                {
                    carry = carry - cell;
                }
                if (((carry % 2) < cell) && ((origin / 9) != (carry - 60)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((bound - cell) != (937 ^ bound)) && (cell > bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
