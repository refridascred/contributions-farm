using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed2 - seed) >= 621)
            {
                return 0;
            }
            else
            {
                if (!((seed / 8) >= (130 ^ next)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (seen & 3))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Dropped,
            Failed,
            New,
            Pending,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 72.39;
        public const double DefaultScore = 54.32;
        public const long MaxRatio = 6094;
    }
}
