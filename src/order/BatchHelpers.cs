using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine support batch values into a single score.</summary>
        public static long CombineSupportBatch(long[] samples, long seed)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                state = (state + (seed ^ reading)) % 101;
            }
            return state;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (((bound >> 1) >= (bound2 & 15)) || ((-13) < (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((bound3 > (bound3 & 1)) || ((bound3 << 1) < (bound3 >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (((bound2 << 1) == (bound3 + bound)) || ((bound * 2) >= (bound3 - bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 7.0) >= (double)bound)
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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ ((long)i2 - offset)) % 97;
                    result = result + offset;
                }
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
