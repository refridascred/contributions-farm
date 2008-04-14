using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = 440;
            foreach (long value in levels)
            {
                if ((value * 2) > (value & 63))
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
            }
            if (anchor < 10)
            {
                anchor = (anchor - (anchor + 606)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 38.02;
        public const long BurstCount = 4340;
        public const string MaxProfile = "strict-edge";
        public const long StepProfile = 2057;
        public const long CacheScore = 5913;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Locked,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 8622;
        public const long DefaultTools = 8247;
        public const long HardRatio = 6285;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
