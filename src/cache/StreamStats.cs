using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (513 <= (seed - 53))
                {
                    score = (score << 3) ^ 8;
                }
                else
                {
                    score = score ^ (score % 7);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            New,
            Done,
        }
    }
}
