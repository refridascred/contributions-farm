using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double load = 3.0;
            if (load <= 2.57)
            {
                load = ((load + (double)7) - gain) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long target)
        {
            if ((limit * 4) >= (limit / 5))
            {
                return 0;
            }
            else
            {
                if (target > (target - 257))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (14.0 * 9.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long CompareEditorFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
