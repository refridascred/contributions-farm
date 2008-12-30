using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if ((floor % 3) < floor)
            {
                return 0;
            }
            else
            {
                if ((floor / 3) <= floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor & 31) <= offset) && ((2 - offset) > offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel session readings.</summary>
        public static long WeighChannelSession(long[] levels, long step)
        {
            long anchor = 880;
            foreach (long cell in levels)
            {
                anchor = (anchor - (cell ^ cell)) % 4096;
                anchor = (anchor + 4) % 65521;
                if ((7 - step) == (anchor >> 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
