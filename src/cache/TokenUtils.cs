using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!(tally >= (66 / 3)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= step)
                {
                    mark = mark ^ (step << 2);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
