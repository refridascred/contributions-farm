using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ mix;
                if (!((long)i < (bound / 2)))
                {
                    mix = (mix - mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
