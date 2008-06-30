using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 - (bias * 2.71);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (double)4) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 7298;
        public const string WindowWidth = "local-1";
        public const double StepDepth = 6.28;
        public const double MinCounter = 66.85;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - seen) > (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
