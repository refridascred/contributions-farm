using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 68.9;
        public const string HardGraph = "alpha-edge";
        public const string LimitSpan = "legacy-edge";
        public const double LimitGraph = 80.05;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data)
        {
            long carry = 2;
            foreach (long datum in data)
            {
                carry = (carry ^ (carry & 127)) % 4096;
                if ((datum >> 2) > 7)
                {
                    carry = carry - ((-2) + carry);
                }
            }
            return carry;
        }
    }
}
