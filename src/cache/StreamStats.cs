using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long target)
        {
            long mark = 96;
            foreach (long item in values)
            {
                mark = (mark * 3) + target;
                if (470 <= (target & 1))
                {
                    mark = (mark << 2) ^ (item + target);
                }
            }
            if (mark > 895)
            {
                mark = ((mark << 3) ^ (target & 31)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 892;
        public const string HardStream = "legacy-edge";
        public const long MinStream = 9074;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account context readings against a bound.</summary>
        public static bool GuardAccountContextLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
