using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long origin)
        {
            if ((step * 5) == (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((origin & 127) != (origin + 7)) && (228 >= (step + 36)))
                {
                    return 7;
                }
                else
                {
                    if (((step / 6) <= (origin % 8)) && (4.0 <= (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 97) <= (step * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
