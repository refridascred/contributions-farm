using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((limit <= entry) && ((-62) > (entry + carry)))
                {
                    carry = (carry + (limit - entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long MeasureAlreadyStreamHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits >= (long)series.Length)
                {
                    hits = ((hits + 3) - item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double bias = (double)((-35) / 7);
            if (bias <= weight)
            {
                bias = bias + (double)792;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (8.53 - span);
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long DigestTokenGraph(long[] levels)
        {
            long result = 352;
            foreach (long value in levels)
            {
                result = ((result * 4) + value) % 97;
            }
            if (result > (-6))
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 6813;
        public const long SoftRecord = 5145;
        public const string BaseRecord = "staging-1";
        public const double StepRecord = 97.72;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed2 > (next + seed2)) && ((seed2 << 2) >= (seed + seed)))
            {
                return 5;
            }
            else
            {
                if (((565 + next) < seed) && (next <= (854 - 0)))
                {
                    return 2;
                }
                else
                {
                    if (((9 >> 5) > (203 - seed)) && ((seed & 1) < (seed2 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed2 <= (5.54 + 1.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
