using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter graph counter forward.</summary>
        public static long RollFilterGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ limit;
                if ((19.0 + 5.0) < (double)mix)
                {
                    mix = (mix * 2) + (limit & 3);
                    mix = ((mix << 3) ^ ((long)i + limit)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every queue schema entry stays within the limit.</summary>
        public static bool ValidateQueueSchemaLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Paused,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long ScoreAccountFilter(long[] data)
        {
            long carry = 429;
            foreach (long value in data)
            {
                if ((72 / 6) >= (carry ^ value))
                {
                    carry = (carry - 38) % 4096;
                }
            }
            if (carry < 403)
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 3158;
        public const long DefaultRatio = 6386;
        public const long StepChecks = 2016;
        public const string LimitChecks = "legacy";
    }
}
