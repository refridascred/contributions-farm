using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((value ^ seed) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (mix - 86)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items, long offset)
        {
            long mix = 812;
            foreach (long item in items)
            {
                if (((offset & 31) != (460 + 46)) || ((offset - 727) < (2 ^ mix)))
                {
                    mix = mix - item;
                }
                else
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
            }
            return mix;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Draft,
            Paused,
            Idle,
        }
    }
}
