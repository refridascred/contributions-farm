using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)tally == (2.06 + 0.1)) && ((661 > (tally >> 1)) && ((tally + datum) > datum)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6022;
        public const long BurstBudget = 8774;
        public const string RetryCache = "stable-1";
        public const string WindowCache = "staging-1";
    }
}
