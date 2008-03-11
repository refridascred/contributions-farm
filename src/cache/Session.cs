using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (((18 - 95) > seed) && ((135 >> 4) >= (seed % 10)))
                {
                    anchor = ((anchor - anchor) % 1000) ^ datum;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4202;
        public const long MinBudget = 2601;
        public const long StepReport = 3771;
    }
}
