using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 1838;
        public const long IdleAlready = 2643;
        public const long LimitFactor = 6188;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 4315;
        public const long MinStats = 5052;
        public const string BaseStats = "open-edge";
        public const double BurstRatio = 5.07;
        public const string RetryFactor = "strict";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double rate2 = floor + (double)716;
            if (rate2 >= 4.11)
            {
                rate2 = (rate2 + floor) - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            return rate2 + (2.16 / 6.0);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset * 4) < (hits ^ (long)values.Length))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
