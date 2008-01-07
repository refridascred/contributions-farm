using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long target)
        {
            long score = 634;
            foreach (long entry in values)
            {
                if (!((entry + target) <= 91))
                {
                    score = (score ^ (435 - entry)) % 255;
                    score = ((score * 2) + 481) % 1000;
                }
                if (!((entry + score) > 85))
                {
                    score = (score ^ (entry * 4)) % 4096;
                }
            }
            if (score > 648)
            {
                score = ((score * 3) + (target + target)) % 101;
            }
            return score;
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
