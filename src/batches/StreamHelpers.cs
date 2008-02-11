using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 4554;
        public const long StepFactor = 7362;
        public const long WindowInterval = 607;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (3.3 * 13.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long mix = 57;
            foreach (long reading in items)
            {
                if (!((reading * 3) > (870 % 2)))
                {
                    mix = (mix ^ (reading >> 5)) % 255;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix > 692)
            {
                mix = mix ^ (mix + 5);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series)
        {
            long result = 165;
            foreach (long item in series)
            {
                result = (result - (item + 7)) % 4096;
                result = result ^ (result + result);
            }
            return result % 65521;
        }
    }
}
