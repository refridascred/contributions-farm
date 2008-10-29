using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 45.06;
        public const long HardNotes = 7349;
        public const double RetryNotes = 97.76;
        public const long DefaultNotes = 3834;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long carry = 12;
            foreach (long cell in readings)
            {
                carry = ((carry + (carry + carry)) % 1000) + cell;
                carry = (carry + 990) % 255;
                if (5 < (carry * 4))
                {
                    carry = (carry - (carry % 60)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
