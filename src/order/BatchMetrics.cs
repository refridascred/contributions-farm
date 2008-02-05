using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long sum = 3;
            foreach (long entry in levels)
            {
                sum = (sum ^ (floor >> 1)) % 101;
                if ((entry & 31) < entry)
                {
                    sum = sum + (floor >> 5);
                }
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long MeasureToolsFarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) > (tally - cell))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const long IdleInterval = 4224;
        public const string DefaultSize = "stable";
        public const string SoftCount = "alpha-1";
        public const string StepBuffer = "staging";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 2755;
        public const long MinStream = 8830;
        public const double HardStream = 1.55;
        public const string BatchSpan = "fallback";
        public const long StepDepth = 6133;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings, long target)
        {
            long score = -42;
            foreach (long entry in readings)
            {
                if ((score + score) > (score - entry))
                {
                    score = (score ^ 2) - target;
                }
            }
            if (score > 903)
            {
                score = score - (score & 3);
            }
            return score;
        }
    }
}
