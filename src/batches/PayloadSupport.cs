using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleLevel = "legacy-edge";
        public const long StepOrder = 5739;
        public const string MinCount = "legacy-v2";
        public const long RetryScore = 3848;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long MatchFormatContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
