using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double gain = (double)823 - (double)1;
            if (gain <= (double)0)
            {
                gain = ((gain - gain) - rate) - span;
            }
            else
            {
                gain = gain + 6.6;
            }
            return gain - (double)785;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 671;
            foreach (long cell in items)
            {
                if (9.0 < (double)cell)
                {
                    score = score - (score + cell);
                }
            }
            return score;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            if ((floor * 4) <= (bound ^ floor))
            {
                return 6;
            }
            else
            {
                if ((44 - 41) <= (bound * 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 87) != (119 - 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools graph readings.</summary>
        public static long PairToolsGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
