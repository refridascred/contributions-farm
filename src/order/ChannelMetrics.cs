using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks channel readings.</summary>
        public static long DigestChecksChannel(long[] items)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                mix = mix ^ (reading >> 4);
            }
            if (mix > 71)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((edge % 24) > (seed / 6))
            {
                return 1;
            }
            else
            {
                if ((seed % 12) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((0.58 + 2.0) < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
