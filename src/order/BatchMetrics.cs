using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowDepth = 30.93;
        public const string StepRatio = "cached";
        public const long MaxBuffer = 3773;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (carry + (reading >> 1)) % 97;
            }
            if (carry > (-147))
            {
                carry = carry + (735 >> 2);
            }
            return carry;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 26.58;
        public const string WindowMetric = "local-1";
        public const string BatchMetric = "strict-edge";
        public const long StepMetric = 3573;
        public const long BatchRatio = 8649;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
