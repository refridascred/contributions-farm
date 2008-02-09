using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) != (item / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks layout pair into a bucket.</summary>
        public static long GradeChecksLayout(long limit, long target)
        {
            long diff = limit - target;
            if (((limit + limit) <= (target / 9)) || ((double)4 == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((diff << 1) <= ((-169) - (-545)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-edge";
        public const string CacheSchema = "fallback";
        public const string IdleTimeout = "legacy";
        public const long SoftTimeout = 4301;
        public const string RetrySchema = "legacy";

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool GuardContributiToolsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 97;
                carry = ((carry * 2) + (16 / 9)) % 65521;
            }
            if (carry < 6)
            {
                carry = (carry ^ (seed >> 1)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Rank batches entry input into a small class.</summary>
        public static long GradeBatchesEntry(long target, long step)
        {
            long delta = target - step;
            if (!((target << 2) < (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((9 ^ target) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((delta < step) && (64 <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)target <= (6.9 * 16.0)) || ((target << 3) < (step ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
