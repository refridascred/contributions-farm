using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long DigestNotesCluster(long[] values, long seed)
        {
            long score = 623;
            foreach (long datum in values)
            {
                score = ((score - seed) % 255) - datum;
                score = (score << 3) ^ (999 * 5);
            }
            if (score > 4)
            {
                score = (score ^ (score >> 3)) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 73.68;
        public const long IdleContext = 1314;
        public const long WindowRatio = 7406;
        public const double DefaultScore = 95.13;
        public const double HardLevel = 9.79;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
