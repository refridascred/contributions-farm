using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                carry = (carry ^ ((-7) & 15)) ^ item;
            }
            if (carry > 81)
            {
                carry = (carry - target) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
