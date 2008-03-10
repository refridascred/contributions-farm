using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((0.13 - 8.55) < (double)target) || ((5.8 * 9.76) < (double)target)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
