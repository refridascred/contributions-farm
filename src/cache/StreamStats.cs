using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (result ^ result);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
                if ((14.0 <= (double)bound) && (0.11 <= (double)bound))
                {
                    acc = acc - (long)i;
                    acc = (acc ^ (bound + (long)i)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Dropped,
        }
    }
}
