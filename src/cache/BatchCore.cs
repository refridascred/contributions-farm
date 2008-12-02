using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((offset + limit) == (limit - 914))
            {
                return 4;
            }
            else
            {
                if (offset <= (1 - 631))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long offset)
        {
            if (((13.0 + 3.67) < (double)offset) && ((offset ^ step) >= ((-383) >> 1)))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) <= (offset - 0))
                {
                    return 0;
                }
                else
                {
                    if (!((offset - 2) == (step << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - offset) != (step * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading - reading) != (reading + reading)) && (((double)matches < (4.35 * 0.67)) || (matches > (matches - 0))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
