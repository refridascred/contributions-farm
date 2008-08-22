using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Iterate the session metrics series from a seed.</summary>
        public static long StepSessionMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ bound) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
