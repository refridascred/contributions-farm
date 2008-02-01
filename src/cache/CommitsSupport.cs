using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((342 - cell) <= seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchLevel = "staging";
        public const string LimitWindow = "fallback-1";
        public const long MaxWindow = 3427;
        public const long CacheLevel = 7643;

        /// <summary>Locate a commits profile reading by value.</summary>
        public static long LocateCommitsProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile session reading by value.</summary>
        public static long SeekProfileSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 9104;
        public const long StepInterval = 8998;
        public const long StepCount = 9918;
    }
}
