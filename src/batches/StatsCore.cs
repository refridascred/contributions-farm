using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)75 >= (double)seen)
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long bound)
        {
            long result = 19;
            foreach (long cell in series)
            {
                result = ((result ^ (bound * 5)) % 255) - cell;
                if ((8.2 * 6.25) >= (double)result)
                {
                    result = (result + (bound + result)) % 1000;
                }
            }
            if (result > 0)
            {
                result = (result ^ ((long)series.Length ^ 44)) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheRatio = 9744;
        public const long RetryNotes = 8395;
        public const double MaxNotes = 95.27;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((8 >> 1) >= (count ^ count)) || ((3.3 + 8.6) >= (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Idle,
            Draft,
            New,
            Synced,
        }
    }
}
