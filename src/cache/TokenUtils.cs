using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate commits filter samples.</summary>
        public static long ScoreCommitsFilter(long[] items, long offset)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((carry % 24) > (reading >> 3))
                {
                    carry = ((carry + 5) % 1000) - offset;
                }
            }
            return carry;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double gain = (offset / 4.0) / 4.0;
            return (gain - (double)(-996)) + bias;
        }
    }
}
