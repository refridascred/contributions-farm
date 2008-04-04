using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double rate2 = (double)(80 & 255);
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a channel schema counter forward.</summary>
        public static long DeriveChannelSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (floor + acc);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc % 16)) % 97) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long offset)
        {
            long state = 1;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (offset - state)) % 1000;
                if (((state % 100) <= (state / 2)) || ((double)entry <= (18.0 * 4.02)))
                {
                    state = (state + (offset % 2)) % 255;
                }
                else
                {
                    state = (state - (67 + entry)) % 101;
                }
            }
            return state;
        }
    }
}
