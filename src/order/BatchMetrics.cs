using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long TallyLayoutSchema(long[] series)
        {
            long anchor = 351;
            foreach (long reading in series)
            {
                anchor = (anchor + (95 % 16)) + reading;
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every filter contributi entry stays within the limit.</summary>
        public static bool ValidateFilterContributiLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
