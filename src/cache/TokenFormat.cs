using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if ((6.24 + 9.5) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((1.95 * 4.2) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.48 * 7.33))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
