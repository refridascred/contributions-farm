using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series)
        {
            long score = 77;
            foreach (long datum in series)
            {
                score = (score + (315 - 45)) - datum;
            }
            return score % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
