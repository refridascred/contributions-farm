using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxLevel = 17.66;
        public const long MaxTimeout = 3106;
        public const long RetryWidth = 52;
        public const long BurstSpan = 2508;
        public const double StepPayload = 0.27;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long FoldClusterAlready(long[] items, long floor)
        {
            long mix = 454;
            foreach (long cell in items)
            {
                mix = mix ^ (706 + cell);
                if (((floor % 64) > (889 + mix)) && ((723 << 1) < cell))
                {
                    mix = (mix ^ (cell % 8)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
