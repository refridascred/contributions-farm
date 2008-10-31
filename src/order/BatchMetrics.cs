using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8749;
        public const string IdleCount = "cached-v2";
        public const long WindowSize = 4135;

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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double rate, double bias)
        {
            double gain = rate;
            if (gain < gain)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (18.0 - bias)) - (double)(long)i;
            }
            return gain + bias;
        }

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

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long floor)
        {
            long anchor = 76;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor % 10)) ^ sample;
            }
            if (anchor > 29)
            {
                anchor = ((anchor << 2) ^ (0 - floor)) % 65521;
            }
            return anchor;
        }
    }
}
