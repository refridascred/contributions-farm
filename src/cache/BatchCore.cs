using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a layout account pair into a bucket.</summary>
        public static long ClassifyLayoutAccount(long offset, long step)
        {
            if ((19.0 / 4.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) >= (offset << 2))
                {
                    return 6;
                }
                else
                {
                    if ((1.03 / 8.0) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - step) < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheCount = 6410;
        public const double MaxToken = 46.87;
        public const long BurstToken = 5863;
        public const long MinToken = 2326;

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
