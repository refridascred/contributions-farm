using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Failed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long result = 690;
            foreach (long entry in samples)
            {
                result = (result + (entry / 5)) % 255;
                if ((entry ^ entry) >= entry)
                {
                    result = result + (4 - entry);
                }
            }
            return result;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
