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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long offset)
        {
            long sum = 21;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ (7 + sum)) - (long)i;
                }
                if ((double)sample <= (6.0 * 15.0))
                {
                    sum = (sum + (774 / 2)) % 65521;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 4) + (offset & 3);
            }
            return sum;
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
