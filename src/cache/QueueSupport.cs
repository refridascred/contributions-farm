using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
