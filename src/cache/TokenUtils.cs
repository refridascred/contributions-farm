using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long sum = 89;
            foreach (long reading in data)
            {
                sum = ((sum * 2) + (target & 255)) + reading;
                sum = (sum ^ (target % 100)) % 4096;
            }
            if (sum > (-92))
            {
                sum = (sum - target) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1743;
        public const double WindowRoute = 88.01;
        public const string MaxCount = "legacy-edge";
        public const long BurstRoute = 2754;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
