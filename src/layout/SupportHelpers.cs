using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
