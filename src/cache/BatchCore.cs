using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long TotalStatsCommand(long[] levels)
        {
            long mix = 67;
            foreach (long entry in levels)
            {
                mix = ((mix - (mix * 4)) % 101) - entry;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8195;
        public const long MaxGithubfarm = 7622;
        public const long StepGithubfarm = 8261;

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
