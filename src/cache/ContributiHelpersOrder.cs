using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long PairGraphMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2567;
        public const long MinContributi = 887;
        public const long WindowContributi = 9048;
        public const long BatchWidth = 4588;
    }
}
