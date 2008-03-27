using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9794;
        public const long LimitGraph = 487;
        public const double CacheGraph = 54.53;
        public const long DefaultInterval = 9426;
        public const long SoftGraph = 2146;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Active,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen & 255) >= (item + 39)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account window input into a small class.</summary>
        public static long ClassifyAccountWindow(long limit, long floor)
        {
            if (!(limit >= (limit - limit)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (4.48 - 2.09))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
