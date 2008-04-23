using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin - origin) != ((long)i << 2)))
                {
                    anchor = (anchor ^ (origin + anchor)) % 4096;
                }
                if (anchor < (anchor % 2))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (origin ^ anchor)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series)
        {
            long state = 4;
            foreach (long value in series)
            {
                if ((value + state) == (102 + state))
                {
                    state = (state ^ (value % 24)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state - state) % 65521;
            }
            return state % 97;
        }
    }
}
