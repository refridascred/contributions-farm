using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm token entries that pass the check.</summary>
        public static long CountGithubfarmTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ datum) <= (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 86.13;
        public const string DefaultWidth = "strict-edge";
        public const long DefaultDepth = 9968;
        public const long MaxSupport = 7420;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            if (limit < (limit2 % 8))
            {
                return 4;
            }
            else
            {
                if ((15.0 / 9.0) < (double)limit2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
