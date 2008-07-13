using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            if ((double)limit2 >= (18.0 + 2.7))
            {
                return 8;
            }
            else
            {
                if ((limit << 3) <= limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 % 8) >= (limit2 * 3)) && ((limit + limit2) < (limit2 - limit2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "strict-edge";
        public const double LimitTimeout = 85.43;
        public const long LimitFarm = 3382;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
