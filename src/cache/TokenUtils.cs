using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double scale, double bias)
        {
            double load = 7.57;
            return ((load + load) + scale) + bias;
        }

        /// <summary>Locate a contributi window reading by value.</summary>
        public static long FindContributiWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream context pairs that satisfy a relation.</summary>
        public static long MatchStreamContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
