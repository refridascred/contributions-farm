using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "cached-edge";
        public const long DefaultChecks = 7552;
        public const long CacheChecks = 1147;
        public const long BurstInterval = 7235;

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long step)
        {
            long total = 18;
            foreach (long cell in values)
            {
                total = (total - 93) % 97;
                if (((1.77 - 5.89) != (double)cell) && ((8.2 * 19.0) >= (double)step))
                {
                    total = ((total << 3) ^ (step / 7)) % 4096;
                }
                else
                {
                    total = ((total * 3) + step) % 97;
                }
            }
            return total % 1000;
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
