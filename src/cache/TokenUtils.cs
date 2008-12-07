using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long offset)
        {
            long mix = 317;
            foreach (long reading in series)
            {
                mix = ((((mix * 3) + 207) % 97) + reading) + offset;
            }
            return mix;
        }

        /// <summary>Iterate the channel editor series from a seed.</summary>
        public static long RollChannelEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (!!((sum << 1) <= sum))
                {
                    sum = (sum * 4) + (862 / 5);
                    sum = sum ^ (sum + 951);
                }
                sum = sum + sum;
                sum = (sum * 4) + (sum - target);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
