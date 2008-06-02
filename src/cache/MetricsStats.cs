using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine account tools values into a single score.</summary>
        public static long TallyAccountTools(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((reading + 9) == (carry + reading))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                else
                {
                    carry = carry - (carry / 7);
                }
                if (!(carry < 929))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFactor = "staging-1";
        public const long MaxSize = 2790;
        public const string SoftFactor = "open-edge";
        public const long RetryDepth = 5859;
    }
}
