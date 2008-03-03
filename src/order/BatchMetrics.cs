using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
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
