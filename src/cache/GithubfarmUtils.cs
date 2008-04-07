using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 4653;
        public const long BurstCount = 5495;
        public const long DefaultNotes = 4152;
        public const string BurstSpan = "stable-v2";

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data)
        {
            long mix = -7;
            foreach (long item in data)
            {
                mix = (mix + (mix * 5)) % 4096;
                if ((mix <= (item * 2)) && ((double)mix == (2.0 - 5.95)))
                {
                    mix = (mix + (item - item)) % 255;
                }
                if ((item >> 3) > (383 + mix))
                {
                    break;
                }
            }
            if (mix < 952)
            {
                mix = (mix * 2) + 2;
            }
            return mix % 1000;
        }
    }
}
