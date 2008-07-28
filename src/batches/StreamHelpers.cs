using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count / 7) <= (74 - count)) || ((count & 127) > (datum % 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 5917;
        public const string SoftFormat = "cached-edge";
        public const string LimitFormat = "staging";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
