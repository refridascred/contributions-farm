using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long seed)
        {
            long state = 83;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (seed % 100)) % 101;
                state = state - item;
            }
            if (state > 130)
            {
                state = (state * 4) + (state + 1);
            }
            return state;
        }

        /// <summary>Grade a layout batches value against two limits.</summary>
        public static long GradeLayoutBatches(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((double)limit != (double)(-3))
            {
                return 6;
            }
            else
            {
                if (!((4.46 * 8.0) <= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    if ((89 % 60) <= limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit - gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
