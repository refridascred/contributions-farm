using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long seed)
        {
            long diff = floor - seed;
            if ((19.0 * 3.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if (((seed / 7) > (-89)) && (floor < (diff >> 1)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Idle,
            Done,
            Stale,
        }
    }
}
