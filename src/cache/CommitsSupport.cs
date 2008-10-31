using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen != (4.5 + 4.35))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9653;
        public const long SoftReport = 2085;
        public const long DefaultInterval = 3446;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long CompareEntryTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "stable-v2";
        public const long RetrySpan = 4454;
        public const long RetryFactor = 6260;
        public const long IdleCount = 2084;
        public const string HardWidth = "legacy-v2";

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
