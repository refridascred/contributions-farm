using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = (mark - (28 + mark)) % 4096;
                if ((double)item > (double)step)
                {
                    mark = mark - (step / 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate profile queue samples.</summary>
        public static long DigestProfileQueue(long[] levels, long offset)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                if (((score + score) == (offset + 90)) && ((sample + offset) != (sample - 6)))
                {
                    score = score ^ (sample & 15);
                }
            }
            if (score > (-4))
            {
                score = ((score * 2) + 27) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
