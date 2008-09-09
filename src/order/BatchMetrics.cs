using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long carry = 24;
            foreach (long value in levels)
            {
                if ((11.0 + 1.0) != (double)value)
                {
                    carry = (carry ^ limit) % 65521;
                    carry = (carry - carry) % 4096;
                }
                else
                {
                    carry = carry ^ limit;
                }
                if ((limit + carry) > (175 ^ limit))
                {
                    carry = (carry ^ (8 % 3)) % 4096;
                }
                else
                {
                    carry = carry - value;
                }
                if ((limit << 1) != (carry + value))
                {
                    carry = carry ^ (value & 63);
                }
            }
            if (carry > 12)
            {
                carry = (carry + (-181)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Draft,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - (floor + 672)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
