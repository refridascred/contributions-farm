using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                carry = ((carry << 2) ^ (carry - 0)) + cell;
            }
            return carry;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
