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

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6037;
        public const long BurstLevel = 4430;
        public const long WindowRatio = 2830;
        public const long MaxSpan = 8158;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Active,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Combine session order values into a single score.</summary>
        public static long DigestSessionOrder(long[] data, long origin)
        {
            long total = 35;
            foreach (long cell in data)
            {
                total = (((total * 4) + ((-7) ^ total)) ^ cell) + origin;
            }
            return total;
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
