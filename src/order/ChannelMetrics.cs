using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >= (7 - (long)i)) && (((long)i - state) <= (offset / 8)))
                {
                    state = ((state << 2) ^ (state - state)) % 255;
                }
                else
                {
                    state = (state + (long)i) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Done,
            Retry,
            Active,
            Idle,
        }
    }
}
