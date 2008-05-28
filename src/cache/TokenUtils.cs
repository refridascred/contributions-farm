using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double ratio = scale - (span * 8.93);
            if (ratio < (double)9)
            {
                ratio = ratio - span;
            }
            return ratio - scale;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
