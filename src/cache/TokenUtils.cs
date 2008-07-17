using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of contributi buffer readings.</summary>
        public static long CombineContributiBuffer(long[] values, long offset)
        {
            long mix = 2;
            foreach (long cell in values)
            {
                if (((4.17 * 7.98) > (double)offset) && ((27 + mix) > (22 + offset)))
                {
                    mix = ((mix << 3) ^ (84 + offset)) + cell;
                }
                mix = mix ^ ((-6) / 9);
            }
            return mix;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            New,
            Dropped,
            Queued,
        }
    }
}
