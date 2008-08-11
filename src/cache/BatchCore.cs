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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long target)
        {
            long step = limit ^ target;
            if (step < (limit - target))
            {
                return 4;
            }
            else
            {
                if (((target * 5) == (736 + 651)) || ((step * 5) >= (step << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (step * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
