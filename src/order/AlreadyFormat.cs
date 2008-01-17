using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((1 + datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value / 9) >= (value >> 3)))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] samples, long floor)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = result - (result >> 2);
                result = result + cell;
            }
            if (result > 90)
            {
                result = result ^ floor;
            }
            return result;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (bias + bias))
            {
                rate = rate + bias2;
            }
            return rate - rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6399;
        public const long CacheGithubfarm = 6864;
        public const long SoftScore = 4807;
        public const long WindowGithubfarm = 1624;
    }
}
