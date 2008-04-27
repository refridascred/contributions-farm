using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 6670;
        public const long LimitCommits = 3471;
        public const long BatchCommits = 1945;
        public const long StepCommits = 611;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long seed)
        {
            long result = 289;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (seed << 1)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7312;
        public const long RetrySize = 5699;
        public const long CacheRoute = 5794;
        public const double StepRoute = 61.02;
        public const long RetryFactor = 2294;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((92 ^ seed) <= (seed % 8))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
