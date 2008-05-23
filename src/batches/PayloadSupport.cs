using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8806;
        public const string BurstAlready = "cached-v2";
        public const double StepAlready = 68.46;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long acc = 77;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry ^ acc)) + offset;
            }
            return acc;
        }
    }
}
