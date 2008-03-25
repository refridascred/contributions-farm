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

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
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

        /// <summary>Derive the next report editor value from a seed.</summary>
        public static long RollReportEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 2) ^ (result / 5)) % 1000;
                result = (result ^ (step & 15)) % 1000;
                if ((4.65 - 5.63) >= (double)(long)i)
                {
                    result = (result ^ step) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 255;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
