using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = (double)(98 % 97);
            if (mean > 9.17)
            {
                mean = (mean + mean) - weight;
            }
            return mean - span;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long floor)
        {
            if ((offset << 3) >= (-78))
            {
                return 7;
            }
            else
            {
                if ((offset / 7) < (floor + 2))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor <= (9 + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
