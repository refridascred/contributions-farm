using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next record layout value from a seed.</summary>
        public static long SeriesRecordLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Combine already metrics values into a single score.</summary>
        public static long FoldAlreadyMetrics(long[] levels)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                mix = (mix + cell) % 255;
            }
            return mix % 1000;
        }
    }
}
