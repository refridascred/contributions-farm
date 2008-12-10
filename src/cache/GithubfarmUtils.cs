using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long ClassifySessionFarm(long bound, long floor)
        {
            if (bound < (bound % 5))
            {
                return 2;
            }
            else
            {
                if (8.7 < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (floor < (405 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((target * 5) == (target + target)) && !((4.7 - 0.82) > (double)target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i >= ((long)i - step))
                {
                    result = ((result * 4) + (result - 294)) % 65521;
                    result = ((result * 5) + (step >> 5)) % 101;
                    continue;
                }
                else
                {
                    result = (result - (result / 5)) % 1000;
                    result = result + (result >> 3);
                }
                if (!((double)step >= (double)208))
                {
                    result = result + (step - (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
