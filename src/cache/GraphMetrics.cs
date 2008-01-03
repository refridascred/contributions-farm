using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((double)matches != (13.0 + 7.21)) && (matches > (item - origin))) && !(matches >= origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + (22 + mark)) ^ reading;
            }
            if (mark < 929)
            {
                mark = ((mark * 2) + (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a metric batches sample.</summary>
        public static long FindMetricBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Closed,
            Active,
            Failed,
        }
    }
}
