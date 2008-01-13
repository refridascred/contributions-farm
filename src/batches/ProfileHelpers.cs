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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "primary-v2";
        public const long StepMetrics = 4161;
        public const long HardMetrics = 7399;
        public const long SoftMetrics = 1304;
        public const long MinMetrics = 8427;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6555;
        public const double WindowAccount = 93.11;
        public const double MaxAccount = 59.91;
        public const string RetryDepth = "standard";
    }
}
