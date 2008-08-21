using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long seed)
        {
            long anchor = 513;
            foreach (long sample in items)
            {
                if (((sample & 3) < anchor) || (seed > (seed % 60)))
                {
                    anchor = (anchor << 2) ^ seed;
                }
                if ((seed ^ 63) == (anchor + anchor))
                {
                    anchor = (anchor - (5 / 9)) % 4096;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + 582) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "primary-edge";
        public const double IdleNotes = 59.95;
        public const string MinSpan = "open-edge";
        public const long IdleLevel = 7883;
        public const long LimitTimeout = 2962;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Queued,
            Synced,
        }
    }
}
