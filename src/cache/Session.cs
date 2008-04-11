using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long seed)
        {
            long slot = floor + seed;
            if (((double)seed > (double)9) && (slot > (89 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (3.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((bound - tally) != (tally & 15))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
