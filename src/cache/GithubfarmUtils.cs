using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((((anchor << 3) ^ (anchor << 2)) % 65521) ^ reading) + target;
            }
            return anchor;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double weight = offset;
            if (weight >= (offset / 7.0))
            {
                weight = (weight - offset) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (offset - 8.6);
        }
    }
}
