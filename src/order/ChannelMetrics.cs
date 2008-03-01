using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 3) + (mix << 2);
                if ((limit >> 5) < (limit / 5))
                {
                    mix = mix - limit;
                    mix = (mix + (mix + mix)) % 255;
                }
                if ((limit * 3) >= (mix + mix))
                {
                    mix = mix ^ limit;
                    mix = ((mix * 2) + (6 * 5)) % 255;
                }
                else
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long step)
        {
            long mark = 42;
            foreach (long datum in levels)
            {
                if ((step < mark) && ((step + step) < step))
                {
                    mark = (((mark * 4) + step) % 101) ^ datum;
                }
            }
            if (mark < 128)
            {
                mark = mark ^ (step + step);
            }
            return mark;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
