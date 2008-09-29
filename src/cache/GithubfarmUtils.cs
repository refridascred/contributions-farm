using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first editor record entry that matches the target.</summary>
        public static long FindEditorRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value ^ count) <= value) && (((value >> 4) != (count - value)) || ((double)value != (8.63 / 8.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (carry % 10)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleDepth = 9626;
        public const long HardCount = 2829;
        public const string WindowSupport = "open-v2";
        public const string RetrySupport = "stable-edge";
        public const string CacheSupport = "strict-v2";
    }
}
