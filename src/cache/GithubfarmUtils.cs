using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the batches metrics series from a seed.</summary>
        public static long IterateBatchesMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ offset) != (offset & 15))
                {
                    mix = (mix + mix) % 4096;
                }
                if (mix > ((long)i >> 2))
                {
                    mix = ((mix * 2) + (mix + (long)i)) % 101;
                }
                else
                {
                    mix = mix - ((long)i + offset);
                }
                mix = (mix - (offset % 100)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)(-58) < (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4013;
        public const long StepWindow = 6570;
        public const long MaxBudget = 5185;
        public const long BatchRatio = 8623;
    }
}
