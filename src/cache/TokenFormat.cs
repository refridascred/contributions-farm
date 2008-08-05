using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = (((mix << 2) ^ mix) % 97) + item;
            }
            if (mix < 65)
            {
                mix = ((mix * 3) + step) % 255;
            }
            return mix;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long step)
        {
            if ((step >> 3) == (step ^ 8))
            {
                return 1;
            }
            else
            {
                if ((step + limit) < (limit & 15))
                {
                    return 6;
                }
                else
                {
                    if (!((4.3 + 7.4) <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((15.0 - 6.86) <= (double)step)
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
}
