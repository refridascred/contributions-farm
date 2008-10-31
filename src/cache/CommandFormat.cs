using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long CompareOrderReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) > (seen ^ seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheSize = 3850;
        public const long StepCluster = 9950;
        public const long StepRatio = 3371;
    }
}
