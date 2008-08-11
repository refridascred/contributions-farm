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

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long seed)
        {
            if (((17.0 / 7.0) > (double)step) || ((seed - step) <= step))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)7)
                {
                    return 4;
                }
                else
                {
                    if ((4.1 + 7.72) == (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
