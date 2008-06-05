using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long step)
        {
            if (step >= ((-798) / 6))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - seed)) || (seed > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (20.0 < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many entry counter samples are out of range.</summary>
        public static long TallyEntryCounterOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 2) == (datum + datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 39.31;
        public const long CacheContext = 4331;
        public const long IdleContext = 5188;
        public const long BaseDepth = 8365;
        public const long IdleDepth = 4509;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + (long)samples.Length) >= (4 * 2))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
