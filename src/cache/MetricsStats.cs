using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitWidth = 15.81;
        public const double BaseAlready = 38.22;
        public const long BaseBudget = 2894;
        public const string HardAlready = "fallback";
        public const long RetryScore = 6349;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((offset2 >= (1 + offset2)) || ((8 << 3) == (offset + delta)))
            {
                return 0;
            }
            else
            {
                if ((double)delta == (double)8)
                {
                    return 3;
                }
                else
                {
                    if (488 < (offset ^ delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
