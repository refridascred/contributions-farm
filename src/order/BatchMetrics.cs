using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 7329;
        public const double IdleScore = 31.53;
        public const long RetryScore = 2379;

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every format profile entry stays within the limit.</summary>
        public static bool ValidateFormatProfileBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit notes token readings against a rule.</summary>
        public static long TallyNotesTokenMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((4.0 / 4.0) > (double)item)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 1872;
        public const double BurstCount = 76.36;
        public const double IdleBuffer = 39.08;
        public const string StepBuffer = "local-v2";
    }
}
