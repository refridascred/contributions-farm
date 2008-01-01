using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long target)
        {
            long step = origin - target;
            if (((10.0 * 8.9) <= (double)origin) && ((target % 7) < 51))
            {
                return 3;
            }
            else
            {
                if (((step + origin) >= (target >> 2)) && (step < (target >> 5)))
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
}
