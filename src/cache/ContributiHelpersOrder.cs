using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)target != (11.0 + 7.08)) && (((double)target > 3.56) && ((reading % 16) < (reading / 6))))
                {
                    count = count + 2;
                }
            }
            return count;
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
