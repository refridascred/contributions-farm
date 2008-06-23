using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long acc = 600;
            foreach (long value in levels)
            {
                if (((double)value > 1.98) || ((value % 2) <= (4 ^ acc)))
                {
                    acc = (acc - ((long)levels.Length & 127)) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ 54) <= (matches - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) == (sample * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
