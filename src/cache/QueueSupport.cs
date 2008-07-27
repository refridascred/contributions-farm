using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 14.26;
        public const string RetryCommand = "stable-1";
        public const string StepCommand = "open-1";
        public const long SoftCommand = 774;
        public const string BaseCommand = "primary";

        /// <summary>Measure how many format filter samples are out of range.</summary>
        public static long MeasureFormatFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches << 2) != ((long)items.Length % 2)) || ((566 + matches) <= (floor >> 3)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
