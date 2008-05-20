using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (step + step)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (step >= (count ^ step))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long bound)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                mark = ((mark * 5) + entry) - bound;
            }
            if (mark > 719)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 65521;
        }
    }
}
