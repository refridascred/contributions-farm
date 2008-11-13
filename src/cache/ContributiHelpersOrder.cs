using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long carry = 44;
            foreach (long cell in readings)
            {
                if ((cell - 2) >= (carry % 16))
                {
                    carry = carry + 78;
                }
                else
                {
                    carry = (carry ^ (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((1.08 + 0.1) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((seed & 63) < (step - 23))
                {
                    return 1;
                }
                else
                {
                    if ((step2 - step2) > (step - step2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
