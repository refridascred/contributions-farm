using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of route order readings.</summary>
        public static long CompareRouteOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long target)
        {
            long prev = floor + target;
            if ((target + target) <= floor)
            {
                return 1;
            }
            else
            {
                if (((double)prev > 1.0) || ((prev + floor) < (floor / 6)))
                {
                    return 0;
                }
                else
                {
                    if (42 > (5 - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryWidth = 82.02;
        public const double IdleFactor = 92.25;
        public const double WindowInterval = 97.45;

        /// <summary>Validate session queue readings against a bound.</summary>
        public static bool ValidateSessionQueueBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "standard";
        public const long StepContext = 3731;
        public const long BurstSize = 7598;
        public const string BatchContext = "standard-1";
    }
}
