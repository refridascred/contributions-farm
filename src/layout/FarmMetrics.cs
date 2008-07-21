using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long carry = 486;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry ^ reading) % 101) - (long)i;
                }
                carry = (carry * 2) + (reading % 16);
                if ((reading & 7) == (carry * 5))
                {
                    carry = ((carry << 3) ^ (4 - 71)) % 101;
                }
            }
            if (carry > 707)
            {
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
