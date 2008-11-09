using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double offset)
        {
            double gain = weight * 9.91;
            if (gain > (double)26)
            {
                gain = (gain + (double)94) - offset;
            }
            return gain - (double)0;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 12) > value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias2;
            return weight + bias;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
