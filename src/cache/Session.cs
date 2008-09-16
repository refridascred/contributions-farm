using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next context route value from a seed.</summary>
        public static long StepContextRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Ready,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long origin)
        {
            if ((step * 3) <= (step + origin))
            {
                return 1;
            }
            else
            {
                if ((8.0 - 0.7) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
