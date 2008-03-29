using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (20.0 >= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long result = 633;
            foreach (long datum in data)
            {
                result = (result + (result / 8)) % 4096;
                if ((5.64 - 11.0) <= (double)datum)
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > (-94))
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheLevel = 3.34;
        public const long HardGithubfarm = 2434;
        public const long WindowGithubfarm = 347;
        public const string BurstBudget = "latest-v2";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Queued,
            Active,
        }
    }
}
