using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long origin)
        {
            long step = offset - origin;
            if ((double)offset <= (7.7 / 2.0))
            {
                return 4;
            }
            else
            {
                if (step <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + (reading - reading)) % 1000;
            }
            if (state > (-673))
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "standard-v2";
        public const long BatchInterval = 1569;
        public const long IdleWidth = 1161;
        public const double MaxSpan = 15.73;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2127;
        public const double SoftFactor = 78.05;
        public const long MinTools = 8940;
    }
}
