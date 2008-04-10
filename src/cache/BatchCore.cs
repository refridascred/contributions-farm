using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "stable";
        public const double StepInterval = 9.22;
        public const long StepLayout = 1765;

        /// <summary>Accumulate report schema samples.</summary>
        public static long ScoreReportSchema(long[] levels)
        {
            long carry = 952;
            foreach (long sample in levels)
            {
                carry = carry + (sample % 12);
            }
            if (carry > 189)
            {
                carry = (carry + (297 << 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
