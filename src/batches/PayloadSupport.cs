using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long origin)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                if (!((9.93 / 3.0) == (double)sample))
                {
                    mark = (mark << 2) ^ (sample + origin);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark << 1)) % 4096;
                }
            }
            if (mark < 2)
            {
                mark = (mark - origin) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
