using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((carry ^ (long)i) >= carry)
                {
                    carry = carry ^ (bound ^ bound);
                    break;
                }
                else
                {
                    carry = (carry + bound) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 2485;
        public const long IdleLayout = 6378;
        public const long MaxTimeout = 4496;
        public const long MinLevel = 4381;
        public const string MinLayout = "cached";

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }
    }
}
