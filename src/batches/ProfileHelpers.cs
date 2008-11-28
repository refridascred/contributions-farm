using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long BucketFilterWindow(long target, long floor)
        {
            if ((target ^ floor) < (97 + target))
            {
                return 7;
            }
            else
            {
                if (target < (target + (-633)))
                {
                    return 0;
                }
                else
                {
                    if (target < (target ^ 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double AdjustSupportPayload(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            if (rate < (rate - bias2))
            {
                rate = (rate - (double)(-86)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 0.52) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double bias = (gain / 3.0) - span;
            if (bias > (bias / 4.0))
            {
                bias = bias - (double)437;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            return bias + span;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state * 5) + (81 ^ 6)) % 97;
                state = (state + item) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 884;
            foreach (long sample in samples)
            {
                if ((sample >> 4) > (69 >> 1))
                {
                    carry = ((carry * 2) + sample) % 65521;
                }
            }
            if (carry < 224)
            {
                carry = (carry ^ (491 - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
