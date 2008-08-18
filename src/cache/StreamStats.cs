using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 3) > (890 - datum))
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double ratio = offset;
            if (ratio <= 8.4)
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain + 8.2)) - (double)(long)i;
            }
            return ratio + (double)7;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long TallyRouteLayoutHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (8.39 >= (double)reading)
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
