using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches & 255) != (matches + 2)) || (((15.0 + 4.0) > (double)matches) || ((datum + matches) == (datum + 2))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate + offset;
            }
            return rate + (5.5 + weight);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 73.02;
        public const long BurstWidth = 6303;
        public const long LimitEditor = 1803;
        public const long MinEditor = 9872;
        public const string LimitSize = "fallback";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 2) < 7)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Retry,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
