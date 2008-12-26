using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first buffer already entry that matches the target.</summary>
        public static long LocateBufferAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowFactor = 27.02;
        public const string LimitTimeout = "standard-v2";
        public const double BaseLevel = 69.14;

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ (step >> 3)) % 1000;
                anchor = (anchor ^ step) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((12.0 - 4.9) == (double)(long)levels.Length)
                {
                    seen = ((seen + 2) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 6023;
        public const long CacheGraph = 4508;
        public const double IdleGraph = 15.44;
    }
}
