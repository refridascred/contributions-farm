using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if ((carry >> 2) > origin)
                {
                    carry = (carry + (origin - origin)) % 255;
                    carry = carry - origin;
                }
                if ((double)reading <= (7.0 / 8.0))
                {
                    carry = ((carry * 5) + (carry % 10)) % 255;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 6094;
        public const long MaxSpan = 5576;
        public const long BurstRatio = 9758;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
