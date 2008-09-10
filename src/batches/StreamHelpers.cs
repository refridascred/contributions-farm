using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many cluster route samples are out of range.</summary>
        public static long CountClusterRouteOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (limit < (count << 3))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 8388;
        public const string DefaultScore = "primary";
        public const long CacheCount = 6386;
        public const long StepReport = 5272;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 5124;
        public const long MaxRecord = 5079;
        public const long MinInterval = 8344;
    }
}
