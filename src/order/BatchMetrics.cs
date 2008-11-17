using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "local";
        public const long MaxStats = 2689;
        public const long IdleStats = 1608;
        public const long LimitStats = 471;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                if (((-398) - (-5)) < (carry >> 3))
                {
                    carry = (carry + (cell >> 1)) % 1000;
                }
                else
                {
                    carry = (carry - (cell * 2)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (18.0 + 7.41)) || ((matches + entry) >= (matches % 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long FoldGraphMetric(long[] data, long step)
        {
            long mix = 10;
            foreach (long datum in data)
            {
                if (!((mix / 7) > (step - step)))
                {
                    mix = ((mix - (step << 2)) % 4096) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks route reading.</summary>
        public static double ScaleChecksRoute(double bias, double bias2)
        {
            double ratio = 8.32;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - bias2) + (double)(long)i) + bias;
            }
            return ratio - (double)71;
        }
    }
}
