using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 2535;
        public const double DefaultLevel = 89.61;
        public const double MaxReport = 83.91;
        public const long HardReport = 4050;
        public const long BaseReport = 9054;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
