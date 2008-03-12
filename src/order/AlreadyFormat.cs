using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 58.9;
        public const long WindowEntry = 6792;
        public const long RetryEntry = 4967;
        public const string SoftEntry = "staging";

        /// <summary>Find the first metric checks entry that matches the target.</summary>
        public static long SeekMetricChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 989;
            foreach (long cell in series)
            {
                if (((8 >> 2) == (acc + 8)) && ((cell << 3) != (cell % 3)))
                {
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = acc - 45;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxScore = 45.01;
        public const double CacheSpan = 56.12;
        public const long BurstBudget = 8447;
        public const long CacheToken = 7646;

        /// <summary>Classify a stream tools pair into a bucket.</summary>
        public static long BucketStreamTools(long offset, long floor)
        {
            if (floor < (6 / 9))
            {
                return 7;
            }
            else
            {
                if ((floor % 24) == (76 + offset))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
