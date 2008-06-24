using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long AuditStreamWindowMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally << 1) == (sample & 63))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double bias = 7.9;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + weight;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long step)
        {
            if (((12.0 * 0.17) > (double)step) && (8.84 > (double)target))
            {
                return 3;
            }
            else
            {
                if ((10.0 * 18.0) < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 6044;
        public const double MaxCommand = 28.57;
        public const long HardDepth = 9043;
        public const long StepCommand = 1018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetrySize = 5631;
        public const long RetrySpan = 97;
        public const long CacheCommits = 3731;
        public const double BurstWidth = 30.19;
        public const long MaxCommits = 2653;

        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapPayloadGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
