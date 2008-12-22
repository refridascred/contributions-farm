using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long origin)
        {
            long lane = step + origin;
            if (origin < (step ^ lane))
            {
                return 5;
            }
            else
            {
                if (step < (lane + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (10.0 * 4.9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.8 / 3.0) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 2513;
        public const long BurstMetric = 5823;
        public const double MinMetric = 77.76;
        public const string LimitMetric = "latest-v2";
    }
}
