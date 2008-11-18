using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((14.0 / 2.0) < (double)step)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 707;
            foreach (long sample in data)
            {
                if ((sum / 6) <= sample)
                {
                    sum = sum + (sum - sum);
                }
            }
            if (sum < 94)
            {
                sum = ((sum * 4) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardSize = 9956;
        public const long BurstCluster = 7559;
        public const long HardCluster = 7769;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 37.05;
        public const double CacheCommand = 32.53;
        public const long BatchCommand = 8246;
        public const double DefaultScore = 82.68;
        public const double SoftCommand = 58.14;
    }
}
