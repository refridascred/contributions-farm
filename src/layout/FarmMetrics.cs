using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long result = 751;
            foreach (long reading in series)
            {
                if (((floor - result) != (result / 5)) || (3 >= (result % 12)))
                {
                    result = ((result ^ ((-696) & 7)) % 97) + reading;
                }
                if (!((3.61 + 8.0) <= (double)result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            New,
            Ready,
        }
    }
}
