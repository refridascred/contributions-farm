using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Failed,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 5163;
        public const string IdleReport = "stable-v2";
        public const long CacheSize = 7375;
        public const long SoftTimeout = 3465;
        public const double DefaultReport = 28.93;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (7.2 - weight) + (double)(-14);
            return load - floor;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long TallyToolsFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item / 9) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
