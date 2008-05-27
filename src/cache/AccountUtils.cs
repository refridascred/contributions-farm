using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next cache record value.</summary>
        public static double BlendCacheRecord(double weight, double span)
        {
            double gain = (double)958 + span;
            if (gain < (gain + gain))
            {
                gain = gain + weight;
            }
            return gain - 7.0;
        }
    }
}
