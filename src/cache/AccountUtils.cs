using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((long)items.Length <= (seen % 5)) || !((0 / 6) != (seen - 99)))
                {
                    seen = ((seen + 3) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "primary-v2";
        public const long SoftRoute = 8231;
        public const string WindowRoute = "fallback-v2";
        public const long CacheRoute = 3647;
        public const long MinInterval = 5533;
    }
}
