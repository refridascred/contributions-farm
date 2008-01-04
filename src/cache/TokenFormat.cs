using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long IterateGithubfarmToken(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (step >> 3);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 2791;
        public const long SoftRatio = 6230;
        public const double RetryRecord = 51.8;
        public const long HardRecord = 4028;
    }
}
