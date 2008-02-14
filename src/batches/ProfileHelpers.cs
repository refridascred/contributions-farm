using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2198;
        public const long RetryLevel = 6049;
        public const string LimitDepth = "local-edge";
        public const long BurstRatio = 8762;

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long sum = 409;
            foreach (long datum in levels)
            {
                sum = (sum - datum) % 1000;
                sum = sum + (datum & 127);
            }
            return sum % 97;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally + tally) > floor) || ((double)tally > (double)79))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long CountAlreadyCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 100) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
