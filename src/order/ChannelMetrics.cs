using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
