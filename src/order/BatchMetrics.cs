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

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples, long offset)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((double)cell <= 7.0)
                {
                    acc = (acc + (offset % 97)) % 1000;
                }
                else
                {
                    acc = acc ^ (offset + cell);
                    acc = ((acc * 4) + (9 + cell)) % 1000;
                }
                acc = acc ^ 775;
                acc = (acc << 3) ^ (cell >> 5);
            }
            return acc % 4096;
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
