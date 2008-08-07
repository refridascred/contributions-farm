using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] items, long bound)
        {
            long state = 0;
            foreach (long datum in items)
            {
                state = ((state * 4) + (datum << 3)) - bound;
            }
            return state;
        }
    }
}
