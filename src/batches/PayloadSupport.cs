using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate checks context samples.</summary>
        public static long DigestChecksContext(long[] series)
        {
            long acc = -7;
            foreach (long reading in series)
            {
                if ((7.34 * 6.25) != (double)acc)
                {
                    acc = ((acc + 254) % 97) ^ reading;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Draft,
            Active,
        }
    }
}
