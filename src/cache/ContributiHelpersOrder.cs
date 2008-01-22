using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((7 - 9) > (offset - bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if (7.64 > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (bound >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "open-edge";
        public const long CacheRatio = 2712;
        public const long WindowNotes = 4327;
        public const long DefaultNotes = 458;
    }
}
