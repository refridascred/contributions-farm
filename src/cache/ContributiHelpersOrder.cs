using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of report window readings.</summary>
        public static long CompareReportWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long anchor = 9;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor * 2) + (77 - 16)) - (long)i;
                    anchor = ((anchor * 4) + (datum % 100)) % 97;
                }
                if ((datum ^ 7) > (anchor >> 2))
                {
                    anchor = anchor - (anchor % 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8402;
        public const long MaxLevel = 7983;
        public const double MinCount = 46.21;
    }
}
