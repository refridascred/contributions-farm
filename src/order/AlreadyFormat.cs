using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            if ((bound - limit) <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) <= (limit * 2))
                {
                    return 2;
                }
                else
                {
                    if (!((10 * 3) < (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4103;
        public const string BatchToken = "fallback-v2";
        public const long BaseFactor = 8162;
        public const long CacheToken = 2286;
        public const long MaxToken = 9002;

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
