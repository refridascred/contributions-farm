using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "latest-edge";
        public const long WindowSession = 3857;
        public const long DefaultDepth = 7248;
        public const string LimitSession = "alpha-v2";

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell / 9);
                if (bound <= (cell << 2))
                {
                    mark = (mark << 2) ^ (bound + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((2.0 - 3.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
