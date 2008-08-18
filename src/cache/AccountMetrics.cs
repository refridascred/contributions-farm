using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen % 8) > (cell / 6))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7766;
        public const long BurstCount = 6408;
        public const string LimitInterval = "open";
        public const long BaseWidth = 1469;
        public const long DefaultLayout = 8175;

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double scale = bias;
            if (scale <= ratio)
            {
                scale = scale + (bias + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - (double)754;
        }

        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long SortTokenMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (!(bound >= 0))
            {
                return 7;
            }
            else
            {
                if (((seed - bound) == (2 - target)) && (target >= (target + target)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
