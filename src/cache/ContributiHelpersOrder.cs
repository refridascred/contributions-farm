using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long step2 = target ^ step;
            if (((-639) / 8) != (target + step))
            {
                return 2;
            }
            else
            {
                if (1 <= step2)
                {
                    return 0;
                }
                else
                {
                    if (((step - target) <= step2) || ((step << 3) >= (target & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Done,
            Stale,
        }
    }
}
