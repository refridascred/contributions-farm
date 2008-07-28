using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double drift = bias / 2.0;
            return (drift + 4.92) + weight;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long acc = 38;
            foreach (long value in values)
            {
                if ((value + acc) == (value - acc))
                {
                    acc = ((acc * 4) + ((-88) + 4)) % 101;
                }
                else
                {
                    acc = acc ^ (acc << 1);
                }
            }
            return acc;
        }
    }
}
