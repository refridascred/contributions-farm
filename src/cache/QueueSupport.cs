using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data, long seed)
        {
            long mix = 10;
            foreach (long sample in data)
            {
                if (seed >= (mix * 3))
                {
                    mix = (mix * 3) + mix;
                    break;
                }
                mix = ((mix << 2) ^ (sample - seed)) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a format stats reading by value.</summary>
        public static long FindFormatStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double load = scale + (bias + bias);
            return load - (bias + bias);
        }
    }
}
