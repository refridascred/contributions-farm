using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 8405;
        public const long StepInterval = 6391;
        public const double HardDepth = 14.93;
        public const long SoftCommand = 6206;
    }
}
