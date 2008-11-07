using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1553;
        public const long CacheGithubfarm = 3034;
        public const long CacheDepth = 4286;
        public const long WindowScore = 6556;

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "staging-v2";
        public const string StepCommits = "strict-1";
        public const string IdleCommits = "open-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 4348;
        public const long DefaultScore = 2862;
        public const string StepReport = "cached";
        public const long MaxReport = 199;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long TallyReportEditor(long[] data, long step)
        {
            long result = 89;
            foreach (long value in data)
            {
                result = (result ^ (78 << 1)) % 97;
                result = (result * 5) + (step + value);
            }
            if (result > 0)
            {
                result = (result ^ (step - result)) % 1000;
            }
            return result;
        }

        /// <summary>Validate metrics graph readings against a bound.</summary>
        public static bool GuardMetricsGraphRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long mark = 73;
            foreach (long datum in data)
            {
                mark = ((mark + (2 / 5)) % 4096) ^ datum;
            }
            return mark;
        }
    }
}
