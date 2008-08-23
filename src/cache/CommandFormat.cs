using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long GradeOrderAccount(long limit, long origin)
        {
            if (3.81 <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((origin & 63) <= (limit * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up checks commits samples.</summary>
        public static long CompareChecksCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 86;
            foreach (long value in samples)
            {
                if ((value + (-59)) != (value - anchor))
                {
                    anchor = ((anchor * 2) + ((long)samples.Length >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "standard-v2";
        public const long CacheCommits = 8945;
        public const long BurstRatio = 2199;
        public const long DefaultWidth = 9009;
    }
}
