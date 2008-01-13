using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long result = -9;
            foreach (long entry in readings)
            {
                result = (result + (entry / 3)) % 101;
            }
            if (result > 584)
            {
                result = (result - (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if ((item - item) <= (result + result))
                {
                    result = (result ^ (item * 4)) % 101;
                }
                else
                {
                    result = (result + (675 + result)) % 255;
                }
                if (result < (result - item))
                {
                    result = (result ^ item) % 4096;
                }
            }
            if (result < (-4))
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6555;
        public const double WindowAccount = 93.11;
        public const double MaxAccount = 59.91;
        public const string RetryDepth = "standard";
    }
}
