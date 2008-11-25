using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double IdleRatio = 60.28;
        public const long WindowCommand = 7894;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 3284;
        public const string BurstSize = "strict-edge";
        public const long SoftCount = 1345;
        public const double StepReport = 51.66;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
