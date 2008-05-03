using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 825;
        public const double CacheEditor = 20.73;
        public const double BaseEditor = 29.42;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((offset <= (offset2 - offset2)) || ((offset * 4) <= cur))
            {
                return 4;
            }
            else
            {
                if ((cur + 66) > (cur / 9))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long target2)
        {
            long bound = target ^ target2;
            if (!((bound * 2) <= (-441)))
            {
                return 8;
            }
            else
            {
                if (((bound / 6) == (bound >> 1)) && (target <= (target2 << 2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
