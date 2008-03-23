using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = (((result ^ (8 * 3)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "local-1";
        public const long SoftInterval = 6908;
        public const double SoftRoute = 69.57;
        public const long BatchWidth = 2165;
        public const long IdleRoute = 9301;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (double)5)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
