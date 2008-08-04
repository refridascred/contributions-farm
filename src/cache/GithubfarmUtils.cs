using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double drift = (double)(7 + 42);
            return ((drift - 4.53) + gain) + span;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
