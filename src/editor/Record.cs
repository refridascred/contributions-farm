using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + weight;
            }
            return rate - (rate - rate);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.43 / 8.0) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "fallback";
        public const long IdleAlready = 5667;
        public const long StepAlready = 9492;
    }
}
