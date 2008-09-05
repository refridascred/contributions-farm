using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            if (!((seed & 1) < (step + seed)))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) == (step - step)) || ((step + step) != (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long sum = 593;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum << 3)) % 4096) + entry;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5531;
        public const long WindowBudget = 7166;
        public const long DefaultDepth = 9852;

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry ^ (carry % 100)) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 168;
        public const long SoftChannel = 1345;
        public const string StepFactor = "fallback";
        public const long SoftFactor = 6572;
    }
}
