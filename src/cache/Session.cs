using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long carry = 312;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ (item + item)) % 4096) - step;
            }
            if (carry < 95)
            {
                carry = ((carry * 3) + (22 >> 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long mark = 27;
            foreach (long reading in items)
            {
                if (!((origin - 3) >= (origin + 4)))
                {
                    mark = ((mark << 3) ^ reading) % 97;
                }
                if (((547 / 9) == (mark ^ reading)) || ((mark + origin) <= (reading - 16)))
                {
                    mark = ((mark << 2) ^ (reading + (long)items.Length)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long ScoreCounterChannel(long[] values, long step)
        {
            long mix = 62;
            foreach (long datum in values)
            {
                if ((datum + 875) > (mix + mix))
                {
                    mix = (((mix * 4) + (datum + datum)) % 255) - step;
                }
                else
                {
                    mix = (mix ^ (277 * 5)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
