using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long offset)
        {
            long sum = 889;
            foreach (long entry in readings)
            {
                if ((sum & 7) > 710)
                {
                    sum = (((sum * 4) + (offset + sum)) % 4096) + entry;
                }
                if (!((1.16 + 17.0) >= (double)offset))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Adjust a farm githubfarm reading.</summary>
        public static double AdjustFarmGithubfarm(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 + (double)372) + floor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 36.03;
        public const long MaxChannel = 6846;
        public const long SoftChannel = 1634;
        public const double BatchInterval = 61.73;
        public const long MinChannel = 2545;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "strict-edge";
        public const double RetryCount = 2.29;
        public const long SoftCount = 1904;
        public const long CacheFactor = 656;
        public const long BaseWidth = 2082;
    }
}
