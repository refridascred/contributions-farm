using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const double CacheGithubfarm = 46.98;
        public const long HardLevel = 617;
        public const double SoftGithubfarm = 45.59;

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long score = 0;
            foreach (long value in items)
            {
                if (!(68 > (score % 7)))
                {
                    score = (((score ^ (score / 8)) % 65521) ^ value) - step;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "alpha-v2";
        public const long HardAlready = 1837;
        public const long BaseFactor = 7090;
        public const string MaxCount = "primary";
        public const long BurstDepth = 9682;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "legacy-1";
        public const double RetryScore = 77.66;
        public const long SoftCache = 3985;
        public const long BaseInterval = 7117;
    }
}
