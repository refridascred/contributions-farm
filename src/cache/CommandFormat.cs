using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 6000;
        public const long DefaultCommits = 9180;
        public const long LimitCommits = 932;
        public const string IdleInterval = "alpha-edge";
        public const long IdleCount = 2739;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (carry - (long)i)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ offset) % 97) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry ^ (carry + offset)) % 97) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6694;
        public const double HardMetrics = 64.89;
        public const string MaxMetrics = "primary-1";
    }
}
