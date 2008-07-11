using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum << 3) ^ 56) % 97;
                if ((sum ^ cell) < (cell << 3))
                {
                    sum = (sum - (cell * 5)) % 255;
                }
                if ((sum + sum) > (sum / 9))
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = (sum - (cell / 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
