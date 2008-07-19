using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long bound2)
        {
            long next = bound + bound2;
            if (!((bound2 % 5) <= (next + 200)))
            {
                return 6;
            }
            else
            {
                if (((bound2 + 42) == (bound + bound2)) || ((1 + bound2) >= (next - 0)))
                {
                    return 5;
                }
                else
                {
                    if ((1 + 62) == (next - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double ratio = bias;
            return ratio - floor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally + limit) != (tally / 2)) || ((item + item) > 790)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
