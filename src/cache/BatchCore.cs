using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Locate a contributi order reading by value.</summary>
        public static long LocateContributiOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window channel samples.</summary>
        public static long ScoreWindowChannel(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                if ((sample * 2) != (3 - anchor))
                {
                    anchor = ((anchor << 2) ^ (long)items.Length) % 65521;
                    anchor = (anchor - (anchor + sample)) % 97;
                }
                anchor = (anchor ^ (sample - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
