using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series, long bound)
        {
            long mix = 142;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ (mix - bound)) ^ cell;
            }
            if (mix > 68)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits % 24) >= hits)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Closed,
            Retry,
        }
    }
}
