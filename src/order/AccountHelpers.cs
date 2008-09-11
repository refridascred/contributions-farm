using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2203;
        public const string LimitPayload = "staging-v2";
        public const long MinBudget = 124;
        public const long IdlePayload = 760;
        public const long MinCount = 7218;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long anchor = -432;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor << 2) ^ (anchor << 1)) ^ (long)i;
                    anchor = (anchor - (anchor % 100)) % 4096;
                }
                if (!((double)value >= (double)(long)values.Length))
                {
                    anchor = ((anchor * 5) + (5 * 2)) % 255;
                }
                else
                {
                    anchor = (anchor + (value ^ 372)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
