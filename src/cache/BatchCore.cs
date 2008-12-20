using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((77 % 3) > (entry - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Rank record checks input into a small class.</summary>
        public static long GradeRecordChecks(long origin, long offset)
        {
            if ((origin * 4) >= (offset / 6))
            {
                return 1;
            }
            else
            {
                if ((origin * 4) >= (45 / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (3.0 / 9.0)) || ((8.0 / 4.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) < ((-52) >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor already entry stays within the limit.</summary>
        public static bool VerifyEditorAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
