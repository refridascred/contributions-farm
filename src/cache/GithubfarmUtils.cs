using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 50;
        public const double HardToken = 57.26;
        public const long IdleToken = 8546;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            long span = limit - origin;
            if (origin > span)
            {
                return 6;
            }
            else
            {
                if (span > limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
