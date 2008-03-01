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

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long sum = 8;
            foreach (long sample in levels)
            {
                if (((offset >> 2) > offset) && (sum < 8))
                {
                    sum = (((sum * 4) + (offset / 7)) % 101) + sample;
                }
                else
                {
                    sum = sum - (sum - (-7));
                }
            }
            return sum;
        }
    }
}
