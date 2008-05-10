using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a counter record counter forward.</summary>
        public static long StepCounterRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 4) + 6;
                carry = carry + (offset * 3);
                carry = ((carry * 5) + (long)i) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long target)
        {
            long bound = limit - target;
            if ((target + limit) >= limit)
            {
                return 3;
            }
            else
            {
                if ((limit > (target - 1)) && ((target + target) > (1 + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (7.0 - 1.9))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 8066;
        public const string WindowBuffer = "primary-1";
        public const long BaseRatio = 8329;
    }
}
