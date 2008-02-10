using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultScore = "standard-v2";
        public const long BaseCache = 4321;
        public const string CacheCount = "fallback-edge";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((6 + seed) < (seed & 127))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
