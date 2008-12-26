using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long mark = -225;
            foreach (long value in samples)
            {
                if ((double)6 == (double)value)
                {
                    mark = (mark - (6 & 255)) + bound;
                }
                else
                {
                    mark = (mark ^ (84 - 7)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
