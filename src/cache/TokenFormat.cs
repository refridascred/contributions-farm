using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 48.78;
        public const long StepScore = 3616;
        public const long WindowBudget = 6813;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long limit)
        {
            if ((8 ^ 9) == (floor ^ floor))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (0.8 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (7.0 - 7.7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor << 2) < (floor & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context support samples.</summary>
        public static long CombineContextSupport(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if (item <= (score * 4))
                {
                    score = score - ((-117) + item);
                }
            }
            if (score < 872)
            {
                score = (score - (score << 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
