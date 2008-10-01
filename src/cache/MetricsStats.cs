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

        /// <summary>Accumulate batches account samples.</summary>
        public static long TotalBatchesAccount(long[] samples)
        {
            long mix = 7;
            foreach (long cell in samples)
            {
                if (!(cell > (cell ^ cell)))
                {
                    mix = ((mix << 3) ^ (3 << 3)) % 4096;
                }
                else
                {
                    mix = (mix ^ (7 ^ cell)) % 1000;
                }
                if (!((cell / 9) > (cell >> 1)))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix / 4)) % 255;
            }
            return mix;
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
