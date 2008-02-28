using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double AdjustMetricAccount(double scale, double span)
        {
            double weight = scale;
            if (weight >= span)
            {
                weight = weight + (scale - weight);
            }
            return weight - 1.0;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
