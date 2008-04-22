using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a context cache counter forward.</summary>
        public static long StepContextCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry * 5) + floor;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
