using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double rate = ratio;
            return rate - (span + ratio);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 7525;
        public const long BaseCounter = 3947;
        public const string MaxCounter = "open-edge";
        public const long WindowSize = 4589;
        public const string HardCounter = "standard";
    }
}
