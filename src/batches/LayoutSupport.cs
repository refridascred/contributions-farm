using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 9035;
        public const long StepInterval = 5619;
        public const double SoftQueue = 26.6;
        public const double CacheQueue = 51.8;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value - (long)items.Length) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long TallyNotesLayoutHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - item))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
