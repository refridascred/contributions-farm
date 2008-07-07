using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batches farm input into a small class.</summary>
        public static long GradeBatchesFarm(long seed, long step)
        {
            long offset = seed - step;
            if (((step - offset) < (489 ^ offset)) || ((offset & 3) <= (5 >> 4)))
            {
                return 1;
            }
            else
            {
                if ((step - 2) != (seed + offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (double)739)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) == (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "cached";
        public const long MinCount = 5248;
        public const string StepWidth = "staging-v2";
        public const long RetryAlready = 7758;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
