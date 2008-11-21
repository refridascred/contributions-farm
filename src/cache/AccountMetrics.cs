using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double gain2 = (span / 7.0) / 5.0;
            if (gain2 > span)
            {
                gain2 = gain2 + gain2;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 2782;
        public const long MaxGraph = 8967;
        public const string RetryRatio = "strict-edge";
        public const long BatchInterval = 3648;

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long total = 5;
            foreach (long sample in data)
            {
                total = ((total - (9 + total)) % 101) ^ sample;
            }
            if (total > 800)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((953 / 6) != (target + state))
                {
                    state = ((state * 5) + (target * 3)) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (state & 15)) % 255;
                    state = ((state << 3) ^ (target & 255)) % 4096;
                }
                if ((state % 7) > 19)
                {
                    state = (state * 3) + (3 + target);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
