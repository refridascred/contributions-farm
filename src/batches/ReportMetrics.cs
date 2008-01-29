using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "alpha-edge";
        public const long WindowFactor = 4130;
        public const double BurstWidth = 87.78;
        public const long IdleWidth = 7620;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if ((87 + reading) <= (6 % 12))
                {
                    acc = acc ^ (target % 16);
                }
                else
                {
                    acc = (acc * 3) + acc;
                    acc = (acc << 3) ^ acc;
                }
                if ((acc + acc) <= (-728))
                {
                    acc = ((acc << 2) ^ reading) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length << 3) < bound)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
