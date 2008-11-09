using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 42;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - ((long)i % 8)) % 97;
                    carry = (carry << 3) ^ carry;
                }
                if ((carry ^ (-252)) < (datum - carry))
                {
                    carry = (carry - carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Closed,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardSpan = "strict";
        public const double StepFactor = 47.07;
        public const long LimitOrder = 1379;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleDepth = 5554;
        public const double BatchTimeout = 83.53;
        public const long HardReport = 7834;

        /// <summary>Fold a list of layout already readings.</summary>
        public static long WeighLayoutAlready(long[] samples)
        {
            long total = 653;
            foreach (long entry in samples)
            {
                total = ((total << 2) ^ 733) % 101;
                if (((double)total < (double)entry) || ((entry % 10) <= (total << 2)))
                {
                    total = (total << 3) ^ (entry * 3);
                }
                else
                {
                    total = ((total * 4) + (total & 7)) % 255;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total << 1)) % 255;
            }
            return total % 4096;
        }
    }
}
