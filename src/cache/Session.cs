using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool VerifyCacheFilterRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowCount = "local";
        public const string LimitWidth = "primary";
        public const string DefaultGithubfarm = "stable-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitLevel = 35.12;
        public const long BurstChannel = 5343;
        public const double StepChannel = 20.14;
        public const long MaxChannel = 3336;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                if ((6.49 - 5.1) > (double)mark)
                {
                    mark = mark - (58 ^ entry);
                }
            }
            return mark;
        }
    }
}
