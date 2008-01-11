using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((5.1 + 7.9) != (double)floor)
                {
                    break;
                }
                result = (result - 94) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
