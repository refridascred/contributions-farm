using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((mark >= (mark << 1)) && ((limit / 7) > 41))
                {
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 2) + ((long)i * 2)) % 255) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long bound)
        {
            long bound2 = target - bound;
            if (bound2 >= (657 ^ target))
            {
                return 0;
            }
            else
            {
                if ((target / 8) > (58 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound == (9.8 / 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
