using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double ProjectSessionQueue(double scale, double span)
        {
            double load = scale;
            if (load > 16.0)
            {
                load = load - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (span * 8.8)) - (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
