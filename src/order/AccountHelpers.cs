using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5330;
        public const long MinLevel = 1947;
        public const long MinWidth = 5652;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels, long step)
        {
            long carry = -10;
            foreach (long cell in levels)
            {
                if ((carry * 4) == (115 & 15))
                {
                    carry = ((carry ^ carry) + cell) + step;
                }
                carry = (carry - (59 % 60)) % 255;
            }
            if (carry < 338)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 944;
        public const string RetryNotes = "staging-edge";
        public const string LimitDepth = "standard-v2";
        public const long IdleScore = 2291;
        public const string DefaultSize = "legacy";

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double ratio = weight * 2.0;
            if (ratio <= (bias * 2.6))
            {
                ratio = ratio - (bias / 4.0);
            }
            return ratio - (double)564;
        }
    }
}
