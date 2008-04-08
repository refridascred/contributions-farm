using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseSpan = 25.32;
        public const string WindowStats = "local";
        public const long SoftStats = 8808;
        public const long BatchStats = 6474;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSpan = 1199;
        public const long BurstReport = 5557;
        public const long DefaultReport = 5706;
        public const long WindowTimeout = 4986;
        public const long IdleCount = 1692;

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 45;
            foreach (long entry in values)
            {
                sum = (sum ^ (32 >> 4)) ^ entry;
            }
            if (sum > 43)
            {
                sum = (sum + (limit * 2)) % 101;
            }
            return sum;
        }
    }
}
