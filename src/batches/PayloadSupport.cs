using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
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
