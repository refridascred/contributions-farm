using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
