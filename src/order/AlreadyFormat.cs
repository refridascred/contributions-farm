using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 3801;
        public const double BurstTimeout = 86.54;
        public const string SoftTimeout = "fallback";
        public const string MaxSize = "fallback-1";
        public const long CacheDepth = 6083;

        /// <summary>Check that every graph session entry stays within the limit.</summary>
        public static bool GuardGraphSessionRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)96)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long cur = step - step2;
            if ((cur << 3) < (cur - 616))
            {
                return 4;
            }
            else
            {
                if ((5 >> 3) > (step2 ^ step))
                {
                    return 6;
                }
                else
                {
                    if ((5.7 * 19.0) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
