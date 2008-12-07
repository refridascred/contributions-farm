using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample & 255) > (sample >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9529;
        public const long IdleNotes = 1378;
        public const long LimitNotes = 9306;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
