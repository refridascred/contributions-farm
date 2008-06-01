using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 3417;
        public const string MaxGraph = "latest-edge";
        public const long IdleGraph = 2173;
        public const long StepGraph = 3776;
    }
}
