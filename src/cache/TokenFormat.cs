using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Paused,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a graph stats pair into a bucket.</summary>
        public static long GradeGraphStats(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((7 ^ bound2) <= (delta ^ bound2))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 != (7.04 * 15.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
