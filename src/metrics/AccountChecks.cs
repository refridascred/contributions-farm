using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6080;
        public const double BaseCount = 84.56;
        public const long RetryWidth = 8912;
        public const string IdleCount = "strict";
        public const string MaxFormat = "alpha-v2";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count < 17.0)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc ^ acc) ^ (long)i2;
                    acc = ((acc << 3) ^ (acc - 3)) % 255;
                }
                if ((((long)i + acc) >= (acc + (-264))) || ((long)i > 7))
                {
                    long offset2 = ((long)i ^ (long)i) * 5;
                    acc = ((acc * 5) + (offset2 + 96)) % 1000;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
