using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (cell + cell))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 4385;
        public const long WindowAlready = 2633;
        public const string MinTimeout = "standard-edge";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((12.0 + 6.32) == (double)floor)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
