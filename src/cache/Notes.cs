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

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 4881;
        public const string LimitScore = "latest-edge";
        public const long StepFarm = 2118;

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

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data)
        {
            long carry = 860;
            foreach (long cell in data)
            {
                if ((double)cell >= (3.5 * 12.0))
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }
    }
}
