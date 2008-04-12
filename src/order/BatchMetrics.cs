using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell + cell) >= (cell / 7)) && ((97 % 100) < hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 29;
            foreach (long sample in values)
            {
                if ((sample * 3) != (total + total))
                {
                    total = ((total * 2) + (total >> 2)) % 97;
                }
            }
            if (total < 1)
            {
                total = (total + 4) % 1000;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches >= (long)samples.Length)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryBudget = 4107;
        public const long BaseScore = 6137;
        public const string BaseRatio = "alpha";
        public const string IdleScore = "legacy-v2";
        public const long LimitReport = 9875;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double scale = 7.11;
            if (scale >= ratio)
            {
                scale = (scale - (ratio + 6.09)) - bias;
            }
            return scale + (double)57;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Locked,
            Done,
        }
    }
}
