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

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double gain = (double)219 * 9.0;
            if (gain > 20.0)
            {
                gain = ((gain - gain) + weight) - offset;
            }
            else
            {
                gain = gain + 9.0;
            }
            return gain - (double)139;
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
