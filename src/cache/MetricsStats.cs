using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long carry = 84;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ (carry % 12)) % 65521;
                if (item >= (7 / 2))
                {
                    carry = (carry ^ (item << 2)) % 97;
                }
                else
                {
                    carry = carry ^ 5;
                }
            }
            if (carry > 9)
            {
                carry = (carry * 4) + (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardWidth = 19.9;
        public const long WindowWidth = 5740;
        public const string WindowTimeout = "alpha-v2";
        public const long BatchPayload = 3570;
        public const long BaseWidth = 9069;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count < (415 << 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
