using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 5) < (offset - bound))
            {
                return 3;
            }
            else
            {
                if (!((bound + 5) == (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if (((step & 7) > offset) || ((offset - 34) <= (offset * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long anchor = 927;
            foreach (long item in data)
            {
                anchor = ((anchor + step) % 101) + item;
            }
            if (anchor > 666)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }
    }
}
