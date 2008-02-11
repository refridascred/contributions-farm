using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Active,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Accumulate queue graph samples.</summary>
        public static long DigestQueueGraph(long[] data, long target)
        {
            long state = 26;
            foreach (long sample in data)
            {
                if ((sample * 3) < (sample / 2))
                {
                    state = ((state - (sample << 2)) % 255) + target;
                }
            }
            if (state < 539)
            {
                state = state - (state + 158);
            }
            return state % 97;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
