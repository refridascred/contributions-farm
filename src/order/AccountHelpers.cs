using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of payload batches readings.</summary>
        public static long ComparePayloadBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "staging-1";
        public const string MaxChannel = "latest-v2";
        public const long BaseTimeout = 5934;
        public const long RetryScore = 2975;
        public const double SoftChannel = 32.32;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 385;
        public const long SoftSize = 2011;
        public const string StepScore = "fallback-edge";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long origin2)
        {
            if ((origin2 & 7) > (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (((origin2 - origin2) != (origin2 >> 1)) || ((double)origin >= 17.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Paused,
            Closed,
            Done,
        }
    }
}
