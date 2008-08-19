using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen > (double)1)
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (long)samples.Length)
                {
                    hits = ((hits + 3) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Idle,
            Done,
        }
    }
}
