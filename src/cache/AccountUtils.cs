using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double ratio = (double)(-295) - (bias + gain);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 0.29;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
