using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "open";
        public const string StepWidth = "legacy-v2";
        public const double LimitContext = 96.29;
        public const long BurstFactor = 8927;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstCount = 3.72;
        public const long BurstBudget = 9239;
        public const double WindowStats = 64.07;
        public const string RetryLevel = "staging-v2";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long offset)
        {
            long sum = -635;
            foreach (long item in readings)
            {
                if (offset >= (item + offset))
                {
                    sum = ((sum << 3) ^ (84 / 7)) % 1000;
                }
                if ((double)offset != (17.0 - 1.58))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum - (offset << 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i + 677)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ (seed % 5)) - (long)i2;
                    carry = (carry * 4) + seed;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
