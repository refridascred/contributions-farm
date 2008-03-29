using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7415;
        public const string BaseWindow = "standard-edge";
        public const double LimitWindow = 14.85;
        public const double DefaultWidth = 57.81;

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowTimeout = 96.37;
        public const long MaxInterval = 4203;
        public const long BurstFactor = 2230;
        public const double SoftTimeout = 38.15;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) < ((long)values.Length + datum))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
