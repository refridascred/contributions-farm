using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "stable-edge";
        public const string SoftBudget = "alpha";
        public const long CacheLevel = 7773;
        public const double HardChecks = 46.99;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8106;
        public const double BaseSize = 52.09;
        public const double CacheProfile = 10.21;
        public const long IdleProfile = 2300;

        /// <summary>Roll a record route counter forward.</summary>
        public static long SeriesRecordRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
