using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long offset)
        {
            if ((7.0 * 5.2) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)offset >= (1.36 + 11.0)) || ((4.8 / 6.0) > (double)step))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 2) != (47 - offset)) || ((double)step <= (0.7 / 2.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Check that every queue token entry stays within the limit.</summary>
        public static bool ValidateQueueTokenLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
