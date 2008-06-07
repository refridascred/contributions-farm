using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 6949;
        public const double MaxScore = 78.68;
        public const double StepBudget = 72.46;
        public const long SoftToken = 5988;
        public const double CacheBudget = 73.38;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if ((score + score) < sample)
                {
                    score = (score * 5) + (9 & 31);
                }
            }
            if (score > (-441))
            {
                score = score ^ (score & 1);
            }
            return score % 4096;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((175 / 8) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
