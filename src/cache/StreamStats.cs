using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 9163;
        public const double CacheNotes = 60.41;
        public const long BurstNotes = 5679;
        public const long IdleNotes = 9825;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Locked,
            Done,
        }
    }
}
