using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data, long offset)
        {
            long mix = 890;
            foreach (long value in data)
            {
                if ((2 < (mix - offset)) || ((1.55 * 2.64) > (double)value))
                {
                    mix = mix + offset;
                }
                mix = (mix ^ value) % 255;
            }
            return mix;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long offset)
        {
            if ((719 + 330) == (5 ^ offset))
            {
                return 4;
            }
            else
            {
                if (8.0 > (9.2 + 0.64))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
