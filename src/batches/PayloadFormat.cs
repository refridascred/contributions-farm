using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((datum & 255) == (matches % 97)) && ((double)558 <= (double)datum)) && (3.0 >= (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long step)
        {
            long next = bound + step;
            if ((19.0 > (double)next) && (next < (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((double)next == (double)(-4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 7792;
        public const long WindowGraph = 9174;
        public const long BurstWidth = 4219;
        public const long StepRatio = 3433;
        public const double BurstGraph = 22.58;
    }
}
