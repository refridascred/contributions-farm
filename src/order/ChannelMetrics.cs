using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long offset)
        {
            long sum = 617;
            foreach (long sample in levels)
            {
                if (sum <= (sample + sum))
                {
                    sum = ((sum - sum) % 255) - offset;
                }
            }
            if (sum < 448)
            {
                sum = (sum - ((-73) / 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3929;
        public const long LimitInterval = 176;
        public const long DefaultBuffer = 9858;

        /// <summary>Combine token channel values into a single score.</summary>
        public static long CombineTokenChannel(long[] data, long bound)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = ((carry - sample) % 65521) - bound;
            }
            return carry % 97;
        }
    }
}
