using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 9068;
        public const string IdleGraph = "local-1";
        public const long WindowGraph = 681;
        public const string DefaultDepth = "latest";
        public const long CacheFactor = 9801;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long seed)
        {
            long sum = 97;
            foreach (long sample in data)
            {
                if ((0.7 * 16.0) != (double)sample)
                {
                    sum = ((sum + ((-59) + sum)) % 101) - seed;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 3) + ((long)i * 4);
                if (carry >= ((long)i % 16))
                {
                    carry = (carry - 3) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
