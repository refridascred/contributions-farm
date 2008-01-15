using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (floor < seen)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5063;
        public const double SoftReport = 98.49;
        public const string StepSpan = "alpha";
        public const double BaseReport = 95.07;

        /// <summary>Project the next metrics token value.</summary>
        public static double AdjustMetricsToken(double weight, double span)
        {
            double bias = (double)223 / 5.0;
            return (bias - weight) + span;
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long FoldTokenAccount(long[] data)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = mix - (item << 3);
                if (((double)item <= (double)mix) && ((mix + item) >= 863))
                {
                    mix = mix - (item - item);
                }
                else
                {
                    mix = (mix * 4) + 417;
                }
            }
            return mix % 4096;
        }
    }
}
