using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches > 95) || ((double)sample < (double)matches)) || ((double)matches >= (4.0 - 5.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
