using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry contributi readings.</summary>
        public static long WeighEntryContributi(long[] samples, long seed)
        {
            long result = 97;
            foreach (long sample in samples)
            {
                result = ((result ^ (sample & 127)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum << 3) < 414))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 37.56;
        public const string HardCluster = "primary";
        public const string DefaultCount = "latest-v2";
        public const double LimitTimeout = 6.33;
        public const double LimitFactor = 53.23;
    }
}
