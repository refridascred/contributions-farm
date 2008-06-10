using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4185;
        public const long CacheBudget = 5503;
        public const double StepSize = 57.88;
        public const double IdleSpan = 30.77;
        public const double SoftRoute = 38.05;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count * 4) <= (limit & 127))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Synced,
        }
    }
}
