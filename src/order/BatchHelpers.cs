using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + 8) + (long)i;
                }
                if (((mix ^ limit) >= limit) || ((7 >> 4) != (limit * 3)))
                {
                    mix = (mix - (datum ^ limit)) % 97;
                }
            }
            if (mix > 55)
            {
                mix = (mix + limit) % 101;
            }
            return mix;
        }
    }
}
