using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metrics cache input into a small class.</summary>
        public static long BucketMetricsCache(long seed, long target)
        {
            if ((seed + target) <= (target + seed))
            {
                return 8;
            }
            else
            {
                if (!((seed + seed) < seed))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed != (16.0 * 13.0)) && ((double)757 == (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double weight = ratio;
            return weight - (bias * 5.0);
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
