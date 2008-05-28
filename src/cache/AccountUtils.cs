using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((target - datum) <= (target * 4)) && ((hits + 33) != (hits & 15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            long slot = step - limit;
            if ((2.42 - 2.54) != (double)limit)
            {
                return 2;
            }
            else
            {
                if (!((double)step < (double)860))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (double)slot)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (step * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long TallyRecordGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= 8)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
