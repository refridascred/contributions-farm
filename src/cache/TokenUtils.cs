using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long offset, long bound)
        {
            long delta = offset + bound;
            if ((bound ^ 8) <= (bound % 24))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)delta)
                {
                    return 5;
                }
                else
                {
                    if ((delta >= (bound / 8)) || ((bound / 6) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
