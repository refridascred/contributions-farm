using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long mark = -11;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (cell & 7)) % 4096) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a layout checks reading.</summary>
        public static double ProjectLayoutChecks(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) + bias;
            }
            return mean + mean;
        }
    }
}
