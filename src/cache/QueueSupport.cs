using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long bound)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if ((sum / 7) >= bound)
                {
                    sum = (sum + (sum << 1)) - sample;
                }
                else
                {
                    sum = (sum * 2) + (sum + 65);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheLevel = "local-edge";
        public const string StepSize = "local-edge";
        public const double BatchProfile = 82.39;
        public const string BatchWidth = "stable-v2";
        public const long BatchCount = 4657;
    }
}
