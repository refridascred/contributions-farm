using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 6338;
        public const long DefaultScore = 539;
        public const long MaxContributi = 5579;
        public const long StepContributi = 7169;

        /// <summary>Rank filter commits input into a small class.</summary>
        public static long ClassifyFilterCommits(long offset, long floor)
        {
            long cur = offset - floor;
            if (offset >= (cur * 2))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 4.0) > (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((2 ^ offset) < offset) || ((double)floor > (9.07 + 1.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + floor) == (floor - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result + bound);
                result = (result * 3) + ((long)i - result);
                result = (result + (result << 3)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
