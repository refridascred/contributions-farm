using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LookupRouteCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 < (rate - rate))
            {
                rate2 = rate2 - (bias + rate);
            }
            return rate2 + rate2;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = -997;
            foreach (long reading in series)
            {
                if ((double)carry < (3.91 - 9.0))
                {
                    carry = ((carry * 5) + carry) ^ reading;
                }
            }
            if (carry < (-260))
            {
                carry = carry - 212;
            }
            return carry % 97;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin > limit) && ((3.5 - 6.1) < (double)limit))
            {
                return 6;
            }
            else
            {
                if ((limit / 9) >= (1 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((174 >> 5) != (limit ^ origin)) || ((origin << 2) != (limit + 9)))
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
}
