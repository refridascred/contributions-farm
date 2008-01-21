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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long seed)
        {
            long diff = target + seed;
            if ((diff - seed) >= target)
            {
                return 8;
            }
            else
            {
                if (((diff * 4) != (seed / 4)) && ((diff / 9) <= (target - 331)))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff > (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
