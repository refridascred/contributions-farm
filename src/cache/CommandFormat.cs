using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((2 / 6) <= (cell ^ matches))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long limit)
        {
            if (!((60 << 2) <= floor))
            {
                return 6;
            }
            else
            {
                if ((390 - floor) <= (limit - 86))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a entry graph figure with a bias.</summary>
        public static double BlendEntryGraph(double ratio, double span)
        {
            double rate = (double)(2 / 7);
            if (rate <= (double)65)
            {
                rate = (rate + span) - ratio;
            }
            return rate - (1.72 * 1.86);
        }
    }
}
