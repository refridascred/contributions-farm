using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen > (8.3 * 8.4))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 7332;
        public const long BurstCount = 8648;
        public const double LimitFormat = 28.16;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool GuardEditorPayloadBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
