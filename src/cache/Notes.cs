using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 41.05;
        public const string SoftCount = "primary-v2";
        public const long StepWidth = 9922;
        public const long RetryCommits = 2243;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry buffer pair into a bucket.</summary>
        public static long SortEntryBuffer(long bound, long target)
        {
            if ((double)bound > (double)target)
            {
                return 5;
            }
            else
            {
                if (!((double)bound >= 7.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long limit)
        {
            if ((limit * 5) == (limit << 2))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) <= (target + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 6) < (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
