using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSize = 50.75;
        public const double LimitProfile = 11.13;
        public const long BatchProfile = 5560;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
