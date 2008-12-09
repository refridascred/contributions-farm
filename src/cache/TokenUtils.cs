using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cache queue value.</summary>
        public static double SmoothCacheQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)6)
            {
                scale = scale + (offset - scale);
            }
            else
            {
                scale = scale - (double)5;
            }
            return scale - scale;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long TallySchemaRecordGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(floor >= entry) || (floor <= (entry + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
