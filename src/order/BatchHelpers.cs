using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank editor stream input into a small class.</summary>
        public static long SortEditorStream(long offset, long seed)
        {
            if (seed >= (35 - offset))
            {
                return 0;
            }
            else
            {
                if ((395 ^ seed) > (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if (((-95) / 8) <= (seed % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < (offset - seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 122;
            foreach (long reading in items)
            {
                if (score <= (score - score))
                {
                    score = (score - (reading & 255)) % 1000;
                }
                if ((double)7 <= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 6006;
        public const long WindowAlready = 992;
        public const long RetryAlready = 8692;
        public const long SoftAlready = 7220;
    }
}
