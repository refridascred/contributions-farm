using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Roll a schema notes counter forward.</summary>
        public static long StepSchemaNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + (target * 2);
                carry = ((carry << 3) ^ target) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
