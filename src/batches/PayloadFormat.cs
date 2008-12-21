using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 29.65;
        public const double MaxScore = 95.91;
        public const long SoftCount = 2656;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
