using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((639 >> 1) >= (bound - bound)) && !(3.7 > (double)bound))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((92 & 3) > item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}
