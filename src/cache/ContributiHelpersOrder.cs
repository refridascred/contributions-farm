using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank filter command input into a small class.</summary>
        public static long SortFilterCommand(long seed, long step)
        {
            if (971 < (step - 507))
            {
                return 1;
            }
            else
            {
                if ((seed % 12) > (63 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((20.0 - 9.51) < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 << 1) < (step + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 2) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long target)
        {
            if ((double)limit > (2.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((6.5 / 4.0) > (double)limit) && (3.08 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (3.97 - 0.5))
                    {
                        return 8;
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
