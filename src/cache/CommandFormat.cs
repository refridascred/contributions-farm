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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (offset & 31)) % 101;
                result = result ^ (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
