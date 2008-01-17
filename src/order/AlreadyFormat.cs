using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) >= (cell << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
