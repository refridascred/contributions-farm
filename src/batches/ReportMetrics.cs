using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = -8;
            foreach (long value in samples)
            {
                carry = carry - (value << 1);
            }
            if (carry > 553)
            {
                carry = (carry + (carry & 255)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Roll a token format counter forward.</summary>
        public static long StepTokenFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + target) != (4 ^ target))
                {
                    sum = (sum ^ 1) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
