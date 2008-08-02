using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long seed)
        {
            if (seed > (seed >> 3))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((step - seed) == (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Failed,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
