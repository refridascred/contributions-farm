using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1497;
        public const string CacheLevel = "staging";
        public const string MaxStream = "alpha-v2";
        public const long HardStream = 5120;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                long span = (origin ^ result) & 15;
                if (((205 - span) < origin) || ((origin % 16) > (span << 3)))
                {
                    span = (span << 3) ^ (span % 60);
                }
                if (result < (9 ^ result))
                {
                    span = (span + (origin + origin)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
