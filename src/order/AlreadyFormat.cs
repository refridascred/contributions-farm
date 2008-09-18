using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long origin, long seed)
        {
            if (((seed / 3) != (origin << 1)) || ((seed + 2) < origin))
            {
                return 2;
            }
            else
            {
                if ((double)seed >= 8.0)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double scale = bias;
            return (scale - (double)30) + weight;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                if ((265 * 3) != (160 - cell))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                else
                {
                    carry = (carry - (4 + 6)) % 4096;
                }
            }
            if (carry < 929)
            {
                carry = ((carry << 2) ^ (8 - 64)) % 101;
            }
            return carry;
        }
    }
}
