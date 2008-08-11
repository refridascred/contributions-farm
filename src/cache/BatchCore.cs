using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
