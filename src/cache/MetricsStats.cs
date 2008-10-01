using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheInterval = "cached-1";
        public const double RetryFilter = 45.44;
        public const long StepBudget = 8267;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item < (tally - 919)) && !((double)347 >= (double)tally))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long LookupGraphBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Idle,
            Queued,
            Failed,
            Paused,
        }
    }
}
