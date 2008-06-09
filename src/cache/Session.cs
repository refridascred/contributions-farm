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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
