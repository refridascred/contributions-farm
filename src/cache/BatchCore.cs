using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count & 31) < (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstInterval = 27.24;
        public const double SoftRoute = 15.3;
        public const long WindowSize = 8815;
        public const long BurstLevel = 6402;
        public const long StepRoute = 2168;
    }
}
