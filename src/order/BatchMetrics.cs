using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((long)values.Length != (datum ^ datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((15 % 5) == (seen - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= (rate / 3.0))
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 40.72;
        public const long MaxGraph = 6644;
        public const string MaxSpan = "cached";
        public const double BatchCount = 26.51;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long sum = -88;
            foreach (long datum in samples)
            {
                if ((sum ^ datum) > sum)
                {
                    sum = sum - (24 % 12);
                }
                else
                {
                    sum = (sum - (datum / 4)) % 4096;
                }
                if ((sum << 1) == (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 27)
            {
                sum = ((sum * 3) + (867 % 64)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
