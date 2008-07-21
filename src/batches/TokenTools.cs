using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long offset)
        {
            long carry = 447;
            foreach (long sample in series)
            {
                if ((sample << 3) <= (sample - 86))
                {
                    carry = carry - (35 + offset);
                }
            }
            return carry;
        }
    }
}
