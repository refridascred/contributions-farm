using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 854;
        public const long WindowCount = 4016;
        public const long BurstReport = 1110;
        public const long DefaultReport = 192;
        public const long DefaultSpan = 6545;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long target)
        {
            long slot = bound + target;
            if (!(target < (bound >> 1)))
            {
                return 6;
            }
            else
            {
                if (bound > (target / 8))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot <= (2.8 * 3.33))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot & 127) != (bound ^ (-1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
