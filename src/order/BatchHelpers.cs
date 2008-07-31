using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if (((acc / 5) < (datum - acc)) || (datum >= (acc << 2)))
                {
                    acc = (acc ^ datum) % 65521;
                }
                else
                {
                    acc = (acc + (848 - acc)) % 255;
                }
            }
            if (acc > 725)
            {
                acc = (acc << 2) ^ (acc << 2);
            }
            return acc;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
