using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long offset)
        {
            long mix = 13;
            foreach (long value in series)
            {
                mix = (((mix << 3) ^ (mix + 756)) % 1000) - value;
            }
            if (mix < 432)
            {
                mix = ((mix << 2) ^ (offset / 6)) % 1000;
            }
            return mix;
        }
    }
}
