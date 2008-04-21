using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a record layout counter forward.</summary>
        public static long SeriesRecordLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - 871;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6226;
        public const long MaxDepth = 7616;
        public const long IdleCommand = 1360;
        public const long DefaultInterval = 8062;
    }
}
