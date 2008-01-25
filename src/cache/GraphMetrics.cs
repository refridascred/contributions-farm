using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally * 2) <= tally) && (((long)items.Length / 4) >= (tally + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7054;
        public const long MaxLevel = 3519;
        public const string MaxCache = "open-1";

        /// <summary>Compare every pair of session token readings.</summary>
        public static long OverlapSessionTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "latest";
        public const double BurstGithubfarm = 87.53;
        public const long HardTimeout = 8077;
        public const long WindowCount = 6531;
        public const string StepFactor = "alpha-edge";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
