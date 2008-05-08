using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double load = (double)(8 + 91);
            if (load < (double)5)
            {
                load = (load - (floor * 1.8)) + weight;
            }
            else
            {
                load = load + (double)(-7);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (floor * 6.0)) - (double)(long)i;
            }
            return load - 6.84;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            New,
            Failed,
        }
    }
}
