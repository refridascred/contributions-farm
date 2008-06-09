using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long carry = 312;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ (item + item)) % 4096) - step;
            }
            if (carry < 95)
            {
                carry = ((carry * 3) + (22 >> 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long seed)
        {
            if ((double)target < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)target > (14.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((target < ((-39) / 3)) || ((seed + target) > (seed >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long seed)
        {
            if ((limit - limit) >= (seed >> 1))
            {
                return 3;
            }
            else
            {
                if ((4 / 4) > (limit - limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
