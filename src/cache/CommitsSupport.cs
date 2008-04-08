using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Pending,
            Retry,
            Draft,
            New,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long origin)
        {
            long gap = target + origin;
            if ((3.31 / 9.0) > (double)gap)
            {
                return 3;
            }
            else
            {
                if (origin >= (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double drift = gain;
            if (drift <= drift)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 20.0) + (double)(long)i;
            }
            return drift + 1.4;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long origin)
        {
            if (origin >= (origin / 2))
            {
                return 7;
            }
            else
            {
                if (((offset * 4) == (492 ^ origin)) && ((offset & 1) != (offset * 5)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
