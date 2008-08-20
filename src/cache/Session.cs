using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseBudget = "fallback-edge";
        public const long SoftDepth = 9325;
        public const long SoftSupport = 8;
        public const long WindowInterval = 5857;
        public const long HardWidth = 6294;

        /// <summary>Compare every pair of buffer already readings.</summary>
        public static long OverlapBufferAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
