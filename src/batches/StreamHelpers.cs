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

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8992;
        public const long DefaultSupport = 5468;
        public const double SoftBudget = 84.73;
        public const long RetryLevel = 3937;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 45;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (mark >> 3)) % 101) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
