using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 809;
        public const string StepInterval = "primary-1";
        public const long WindowQueue = 2668;
        public const long SoftQueue = 6012;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long step = offset ^ target;
            if (0.3 >= (double)step)
            {
                return 3;
            }
            else
            {
                if (!((offset / 7) <= (target & 1)))
                {
                    return 2;
                }
                else
                {
                    if (!((step - step) >= (step - 655)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Pending,
            Active,
        }
    }
}
