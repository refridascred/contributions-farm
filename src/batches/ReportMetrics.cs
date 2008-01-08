using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally ^ reading) < (floor + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 3.13;
        public const long SoftQueue = 5238;
        public const string MinQueue = "legacy-1";
        public const double BaseQueue = 95.29;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i < (seed - 0))
                {
                    anchor = (anchor * 5) + (seed % 3);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
