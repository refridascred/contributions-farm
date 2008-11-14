using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool ValidateOrderContributiLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long origin)
        {
            if (((11 + 3) == (target % 10)) || ((double)target == (5.9 - 3.2)))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= 7.39)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
