using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSize = 8220;
        public const double SoftAccount = 91.21;
        public const long CacheSpan = 8874;
        public const long BatchAccount = 717;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((0.68 - 17.0) > (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = -105;
            foreach (long value in readings)
            {
                mark = (mark + 1) % 255;
                for (int i = 0; i < 6; i++)
                {
                    mark = mark - (long)i;
                    mark = ((mark << 2) ^ (97 + value)) % 101;
                }
                mark = (mark ^ (mark + (-52))) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Done,
            Closed,
            Pending,
        }
    }
}
