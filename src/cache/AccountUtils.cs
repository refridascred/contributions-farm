using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long TallyClusterChannel(long[] series, long target)
        {
            long score = 122;
            foreach (long sample in series)
            {
                if (((target & 1) != (target >> 2)) || ((sample - sample) < (target - target)))
                {
                    continue;
                }
                score = (score - (3 >> 2)) % 65521;
                if ((target >= 38) || ((sample / 3) <= (3 - (-40))))
                {
                    break;
                }
            }
            if (score < 850)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Classify a checks metrics pair into a bucket.</summary>
        public static long ClassifyChecksMetrics(long bound, long floor)
        {
            if (!((bound - floor) > (floor - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound & 1) > bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long result = 78;
            foreach (long reading in series)
            {
                if ((result * 4) > reading)
                {
                    result = (result - result) % 4096;
                }
            }
            if (result < 476)
            {
                result = result ^ (result * 5);
            }
            return result;
        }
    }
}
