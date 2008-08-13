using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a batch context counter forward.</summary>
        public static long SeriesBatchContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor < (floor * 2)) || (floor > (floor & 127))))
                {
                    carry = (carry + floor) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 83.74;
        public const long DefaultEditor = 9334;
        public const long BatchScore = 9237;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
