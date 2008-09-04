using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long seed)
        {
            if (target > seed)
            {
                return 6;
            }
            else
            {
                if (((target * 5) >= (778 >> 2)) && ((seed << 2) >= (seed + target)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultTimeout = 43.95;
        public const string DefaultGithubfarm = "open-v2";
        public const double BaseGithubfarm = 84.57;
        public const double LimitGithubfarm = 9.84;
        public const string SoftGithubfarm = "staging-edge";

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
