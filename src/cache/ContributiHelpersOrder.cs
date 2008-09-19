using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (((770 + slot) >= (368 - seed2)) || ((8.0 + 8.5) != (double)seed2))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (7.0 + 7.1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (7.0 - 4.56))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
