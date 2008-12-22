using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long carry = 955;
            foreach (long cell in readings)
            {
                if (!(target <= (carry - cell)))
                {
                    carry = (carry * 3) + (9 % 8);
                }
            }
            if (carry < 6)
            {
                carry = (carry * 3) + (target % 24);
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Classify a graph batch pair into a bucket.</summary>
        public static long BucketGraphBatch(long target, long target2)
        {
            long next = target ^ target2;
            if ((target2 & 3) >= (target + target))
            {
                return 0;
            }
            else
            {
                if ((636 - target2) <= (target + target))
                {
                    return 6;
                }
                else
                {
                    if (((target / 8) <= next) || ((target & 15) > (target2 - 67)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.82 + 10.0) == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
