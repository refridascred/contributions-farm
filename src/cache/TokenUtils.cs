using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum ^ sum) - item;
                if (target <= (85 + 30))
                {
                    sum = (sum - sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                total = (total ^ 8) + cell;
            }
            if (total < 7)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
