using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double gain = (6.8 / 5.0) / 6.0;
            if (gain <= (gain - gain))
            {
                gain = ((gain - gain) - scale) - offset;
            }
            return gain - (gain * 5.29);
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long BucketReportPayload(long offset, long offset2)
        {
            if ((offset >= 62) || ((42 - 60) >= (offset * 3)))
            {
                return 1;
            }
            else
            {
                if ((offset2 + 82) >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
