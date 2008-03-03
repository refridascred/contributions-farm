using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry % 8) < (entry & 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
