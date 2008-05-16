using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 2;
            foreach (long value in series)
            {
                carry = carry - value;
                carry = (carry << 2) ^ ((-400) << 3);
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
