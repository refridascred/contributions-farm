using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Synced,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long bound)
        {
            if (((bound + bound) >= step) && ((bound + step) != (step + step)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (double)24) || ((6.77 + 3.2) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((44 + bound) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
