using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryScore = 8194;
        public const double BaseEditor = 63.33;
        public const long StepScore = 8792;
        public const string MaxScore = "open";
        public const string DefaultEditor = "local-1";

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values)
        {
            long score = 73;
            foreach (long item in values)
            {
                if ((score < (item - score)) && ((double)score > (5.1 + 5.72)))
                {
                    score = (score << 2) ^ (item - item);
                }
            }
            return score;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long BucketWindowSchema(long step, long limit)
        {
            if ((0 % 2) > (limit - limit))
            {
                return 2;
            }
            else
            {
                if (!((double)step != (12.0 / 6.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (6.0 / 3.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
