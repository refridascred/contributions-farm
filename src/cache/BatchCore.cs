using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)result != (20.0 / 7.0)))
                {
                    result = result + (result - (long)i);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((delta - delta) != (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((delta - 3) > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) != (seed2 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
