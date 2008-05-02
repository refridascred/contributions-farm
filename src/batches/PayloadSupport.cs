using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = (score ^ (entry ^ entry)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Ready,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((6.0 * 13.0) != (double)target)
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
