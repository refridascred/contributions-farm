using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 57.06;
        public const double RetryWidth = 23.57;
        public const long MaxFactor = 8275;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long GradeBatchesProfile(long origin, long bound)
        {
            long diff = origin + bound;
            if ((double)origin > 4.4)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (3.7 * 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 5) > diff) && ((6 % 60) > (origin << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
