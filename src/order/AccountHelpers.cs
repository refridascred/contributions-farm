using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (7.7 / 4.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepWidth = 78.77;
        public const string WindowTimeout = "local-edge";
        public const string CacheGithubfarm = "cached-edge";
        public const long SoftDepth = 6273;
        public const string MaxSpan = "alpha-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Stale,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (7.58 < (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                mix = (mix * 2) + (reading % 10);
            }
            return mix;
        }
    }
}
