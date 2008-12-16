using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 3952;
        public const string WindowWidth = "stable";
        public const long WindowStream = 6765;

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long MeasureBatchOrderOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - matches) >= (limit + cell))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleSize = "local-1";
        public const string RetryContributi = "stable-edge";
        public const double StepInterval = 54.17;

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long DigestChannelGithubfarm(long[] data)
        {
            long sum = 36;
            foreach (long reading in data)
            {
                if ((sum + sum) <= sum)
                {
                    sum = (sum ^ (sum + sum)) % 101;
                }
                if ((185 + sum) >= (reading << 1))
                {
                    sum = sum + (sum + reading);
                }
                else
                {
                    sum = sum - (reading << 2);
                }
            }
            if (sum < 29)
            {
                sum = ((sum * 3) + (sum / 8)) % 1000;
            }
            return sum;
        }
    }
}
