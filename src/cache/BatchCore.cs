using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5011;
        public const long SoftBatch = 6292;
        public const string StepLevel = "standard-1";
        public const string WindowBatch = "fallback-1";
        public const string HardSpan = "strict-v2";

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels, long seed)
        {
            long mark = 630;
            foreach (long value in levels)
            {
                if ((double)seed == (double)mark)
                {
                    mark = ((mark + (seed ^ (-404))) % 1000) + value;
                }
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long offset)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if ((4.0 - 19.0) < (double)value)
                {
                    acc = ((acc * 4) + (value >> 4)) + offset;
                }
            }
            if (acc > 37)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }
    }
}
