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

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset >> 4) >= cur)
            {
                return 6;
            }
            else
            {
                if (!((cur + offset) < (step >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((729 * 5) <= (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (79 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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
