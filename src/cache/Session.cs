using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark / 8)) % 97) + datum) + origin;
            }
            if (mark < 190)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepCount = 94.52;
        public const long BaseSession = 5952;
        public const string RetrySession = "legacy-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "legacy-edge";
        public const long BatchContext = 761;
        public const long BurstContext = 1661;
        public const double CacheLevel = 32.44;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (floor << 2)) % 65521;
                result = (result << 2) ^ (result << 2);
                result = (result - (floor - (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
