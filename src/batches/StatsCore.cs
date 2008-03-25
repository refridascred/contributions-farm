using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long CountPayloadChecksMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((348 / 9) >= seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 8835;
        public const string LimitTools = "local-edge";
        public const double SoftTools = 3.72;
        public const long MinTimeout = 2631;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a route graph sample.</summary>
        public static long LocateRouteGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = total - ((long)i + total);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
