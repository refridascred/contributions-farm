using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up account buffer samples.</summary>
        public static long OverlapAccountBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count & 63) < (sample / 7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long origin)
        {
            if ((12.0 + 1.1) >= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin % 16) != (target + target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
